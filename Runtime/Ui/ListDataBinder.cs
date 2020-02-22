using UnityEngine;

namespace Tobe.Core
{
    public abstract class ListDataBinder<TData, TListItem> : MonoBehaviour where TListItem : class
    {
        protected abstract IListView<TData> View { get; }

        protected abstract IListManager Manager { get; }


        public void Bind()
        {
            Manager.Bind<TData, TListItem>(View, Bind);
        }

        protected abstract void Bind(TData model, TListItem item);
    }
}