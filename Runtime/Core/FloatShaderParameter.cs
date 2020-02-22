using System;
using UnityEngine;

namespace Tobe.Core
{
    [Serializable]
    public class FloatShaderParameter : ShaderParameter<float>
    {
        public override void ApplyValue(MaterialPropertyBlock materialPropertyBlock)
        {
            materialPropertyBlock.SetFloat(Id, value);
        }
    }
}