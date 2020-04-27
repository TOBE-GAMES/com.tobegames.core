using System;
using UnityEngine;

namespace Tobe.Core
{
    public abstract class MonoComponent : MonoBehaviour, IComponent
    {
        private void Awake()
        {
            OnAwake();
        }

        protected virtual void OnAwake()
        {
            
        }


        private void Update()
        {
            OnUpdate();
        }

        protected virtual void OnUpdate()
        {
            
        }
        
        public virtual  bool GetEnabled()
        {
            return enabled;
        }

        public virtual void SetEnabled(bool value)
        {
            enabled = value;
        }

        public void ToggleEnabled()
        {
            SetEnabled(!GetEnabled());
        }
    }
}