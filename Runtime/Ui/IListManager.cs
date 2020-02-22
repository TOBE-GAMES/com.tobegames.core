using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Tobe.Core
{
    public interface IListManager : IManager
    {
        void Bind<TDataModel, TListItem>(IListView<TDataModel> view, Action<TDataModel, TListItem> onItemCreated)
            where TListItem : class;
    }
}