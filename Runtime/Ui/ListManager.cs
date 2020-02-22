using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Tobe.Core
{
    public class ListManager : IListManager
    {
        private readonly IListItemFactory _listItemFactory;

        public ListManager(IListItemFactory listItemFactory)
        {
            _listItemFactory = listItemFactory;
        }


        public void Bind<TDataModel, TListPrefab>(IListView<TDataModel> view,
            Action<TDataModel, TListPrefab> onItemCreated) where TListPrefab : class
        {
            var container = view.Container;

            container.Clear();

            var data = view.DataSource.GetData();


            foreach (var model in data)
            {
                var instance = _listItemFactory.Create<TListPrefab>();

                onItemCreated?.Invoke(model, instance);

                container.Append(instance);
            }
        }
    }
}