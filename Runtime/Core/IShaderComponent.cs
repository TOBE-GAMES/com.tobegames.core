using UnityEngine;

namespace Tobe.Core
{
    public interface IShaderComponent
    {
        void SetInt(int id, int value);
        
        void SetInt(IntParameterComponent component);
        
        void SetColor(int id, Color value);
        
        void SetColor(ColorParameterComponent component);
    }
}