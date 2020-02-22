using UnityEngine;

namespace Tobe.Core
{
    public interface IShaderParameter<TValue> : IShaderParameterBase
    {
        TValue GetValue();
        void SetValue(TValue parameterValue);
    }

    public interface IColorParameter : IShaderParameter<Color>
    {
        
    }
    
    public interface IIntParameter : IShaderParameter<int>
    {
        
    }
}