using UnityEngine;

namespace Tobe.Core
{
    [RequireComponent(typeof(ShaderComponent))]
    public class ShaderComponent : MonoBehaviour, IShaderComponent
    {
        private Renderer _renderer;

        private MaterialPropertyBlock _materialPropertyBlock;
        
        private void Awake()
        {
            _renderer = GetComponent<Renderer>();
            
            _materialPropertyBlock = new MaterialPropertyBlock();
        }

        public void SetInt(int id, int value)
        {
            _materialPropertyBlock.SetInt(id, value);
            _renderer.SetPropertyBlock(_materialPropertyBlock);
        }

        public void SetInt(IntParameterComponent component)
        {
            _materialPropertyBlock.SetInt(component.Id, component.GetValue());
            _renderer.SetPropertyBlock(_materialPropertyBlock);
        }

        public void SetColor(int id, Color value)
        {
            _materialPropertyBlock.SetColor(id, value);
            _renderer.SetPropertyBlock(_materialPropertyBlock);

        }

        public void SetColor(ColorParameterComponent component)
        {
            _materialPropertyBlock.SetColor(component.Id, component.GetValue());
            _renderer.SetPropertyBlock(_materialPropertyBlock);

        }
    }
}