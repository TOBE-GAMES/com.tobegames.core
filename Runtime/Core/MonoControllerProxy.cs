using UnityEngine;
using Zenject;

namespace Tobe.Core
{
    public abstract class MonoControllerProxy<TController, TView> : MonoBehaviour, IController where TController : IController where TView : IView
    {
        protected TController Controller { get; private set; }

        protected TView View { get; private set; }

        [Inject]
        private void Constructor(TController controller)
        {
            Controller = controller;
        }
        
        private void Awake()
        {
            View = GetComponent<TView>();
         
            OnAwoke();
        }

        protected virtual void OnAwoke()
        {
         
        }
    }
}