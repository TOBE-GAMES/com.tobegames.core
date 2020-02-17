using System;
using System.Collections.Generic;

namespace Tobe.Core
{
    public class SimpleListControllerProxy : MonoControllerProxy<IListController, SimpleListView>, IListController
    {
        public void Bind<TDataModel, TListPrefab>(IListView<TDataModel> view, Action<TDataModel, TListPrefab> onItemCreated) where TListPrefab : class
        {
            Controller.Bind((IListView<TDataModel>) View, onItemCreated);
        }
    }
}