﻿using System;

namespace Tobe.Core
{
    public interface IListView<TDataModel> : IView
    {
        Action ListUpdating { get; }
        
        Action ListUpdated { get; }
        
        IAsyncDataSource<TDataModel> DataSource { get; }
        
        
        IListContainer Container { get; }
    }
}