using System;
using System.Collections.Generic;

namespace Tobe.Core
{
    public interface IListController : IController
    {
        void Bind<TDataModel, TListPrefab>(IListView<TDataModel> view, Action<TDataModel, TListPrefab> onItemCreated) where TListPrefab : class;
    }
}