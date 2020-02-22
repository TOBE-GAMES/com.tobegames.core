using System;
using UnityEngine;

namespace Tobe.Core
{
    [Serializable]
    public class ColorShaderParameter : ShaderParameter<Color>
    {
        public override void ApplyValue(MaterialPropertyBlock materialPropertyBlock)
        {
            materialPropertyBlock.SetColor(Id, value);
        }
    }
}