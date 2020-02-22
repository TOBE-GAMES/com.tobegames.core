using System;
using UnityEngine;

namespace Tobe.Core
{
    [Serializable]
    public abstract class ShaderParameter<TValue> : ShaderParameterBase
    {
        [SerializeField]
        public TValue value;
    }
    
    [Serializable]
    public abstract class ShaderParameterBase
    {
        [SerializeField] public string parameterName;

        private int? _id;

        public int Id => _id ?? (_id = Shader.PropertyToID(parameterName)).Value;

        public abstract void ApplyValue(MaterialPropertyBlock materialPropertyBlock);
    }
}