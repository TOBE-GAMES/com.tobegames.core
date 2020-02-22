using System;
using UnityEngine;

namespace Tobe.Core
{
    [Serializable]
    public class IntShaderParameter : ShaderParameter<int>
    {
        public override void ApplyValue(MaterialPropertyBlock materialPropertyBlock)
        {
            materialPropertyBlock.SetInt(Id, value);
        }
    }
}