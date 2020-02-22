using UnityEngine;

namespace Tobe.Core
{
    public class IntParameterComponent : ShaderParameterComponent<int>, IIntParameter
    {
        protected override void UpdateComponentValue(IShaderComponent component)
        {
            component.SetInt(Id, GetValue());
        }
    }
}