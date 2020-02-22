using UnityEngine;

namespace Tobe.Core
{
    public class ColorParameterComponent : ShaderParameterComponent<Color>, IColorParameter
    {
        protected override void UpdateComponentValue(IShaderComponent component)
        {
            component.SetColor(Id, GetValue());
        }
    }
}