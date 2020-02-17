using System;
using System.IO;
using UnityEngine;

namespace Tobe.Core
{
    public abstract class ListView<TDataModel> : MonoView<IListView<TDataModel>>, IListView<TDataModel>, IListContainer
    {
        public Transform itemsContainer;

        public abstract TDataModel[] Data { get; }

        public Action ListUpdating { get; }
        
        public Action ListUpdated { get; }
        
        
        
        public abstract IAsyncDataSource<TDataModel> DataSource { get; }
        
        public virtual IListContainer Container => this;

        public void Clear()
        {
            itemsContainer.DestroyAllChildren();
        }

        public void Append<TListPrefab>(TListPrefab instance)
        {
            var component = instance as Component;

            if (component == null)
                throw new Exception("Cannot cast type " + nameof(TListPrefab) + " to " + nameof(Component));

            component.name = "List item " + itemsContainer.childCount;
            
            component.transform.SetParent(itemsContainer, false);
        }
    }
}