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
        

        public bool GetActive()
        {
            return gameObject.activeSelf;
        }

        public void SetActive(bool value)
        {
            gameObject.SetActive(value);
        }

        public void ToggleActive()
        {
            SetActive(!GetActive());
        }
    }
}