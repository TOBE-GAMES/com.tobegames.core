using System.Linq;
using UnityEngine;
using Zenject;

namespace Tobe.Core
{
    public abstract class ManagerProxy<TManager, TView> : MonoBehaviour
        where TManager : class, IManager where TView : class, IView
    {
        protected TManager Manager { get; private set; }

        protected TView View { get; private set; }

        
        [Inject]
        private void Constructor(DiContainer container)
        {
            View = GetComponentsInChildren<MonoBehaviour>().OfType<TView>().FirstOrDefault();

            Manager = GetManager(container);
        }

        protected abstract TManager GetManager(DiContainer container);
        
        private void Awake()
        {
            OnAwake();
        }

        protected virtual void OnAwake()
        {
        }
    }
}