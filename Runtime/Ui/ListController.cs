using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Tobe.Core
{
    public class ListController : IListController
    {
        private readonly IListItemFactory _listItemFactory;

        public ListController(IListItemFactory listItemFactory)
        {
            _listItemFactory = listItemFactory;
        }


        public void Bind<TDataModel, TListPrefab>(IListView<TDataModel> view,
            Action<TDataModel, TListPrefab> onItemCreated) where TListPrefab : class
        {
            var container = view.Container;

            container.Clear();

            var data = Task.Run(async () => { return await view.DataSource.GetData(); });

            data.Wait();

            foreach (var model in data.Result)
            {
                var instance = _listItemFactory.Create<TListPrefab>();

                onItemCreated?.Invoke(model, instance);

                container.Append(instance);
            }
        }
    }
}