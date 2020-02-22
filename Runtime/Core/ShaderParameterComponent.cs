using System;
using UnityEngine;

namespace Tobe.Core
{
    public abstract class ShaderParameterComponent<TValue> : MonoBehaviour, IShaderParameter<TValue>
    {
        [SerializeField]
        private string parameterName;

        [SerializeField] private ShaderComponent shaderComponent;

        [SerializeField]
        private TValue value;
        
        public void SetValue(TValue paramValue)
        {
            value = paramValue;
            UpdateComponentValue(shaderComponent);
        }

        public TValue GetValue()
        {
            return value;
        }

        protected abstract void UpdateComponentValue(IShaderComponent component);

        public string Name => parameterName;

        private int? _id;

        public int Id => _id ?? (_id = Shader.PropertyToID(Name)).Value;
        
        public bool continuousUpdate;

        private void Update()
        {
            if (continuousUpdate)
            {
                SetValue(value);
            }
        }
    }
}