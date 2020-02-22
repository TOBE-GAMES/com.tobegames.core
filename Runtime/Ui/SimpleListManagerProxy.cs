using System;
using System.Collections.Generic;
using Zenject;

namespace Tobe.Core
{
    public class SimpleListManagerProxy : ManagerProxy<ListManager, SimpleListView>, IListManager
    {
        public void Bind<TDataModel, TListPrefab>(IListView<TDataModel> view, Action<TDataModel, TListPrefab> onItemCreated) where TListPrefab : class
        {
            Manager.Bind((IListView<TDataModel>) View, onItemCreated);
        }

        protected override ListManager GetManager(DiContainer container)
        {
            return container.Instantiate<ListManager>();
        }
    }
}