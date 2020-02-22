using UnityEngine;

namespace Tobe.Core
{
    #pragma warning disable 0649
    public class SimpleObjectView : MonoBehaviour, ISimpleObjectView
    {
        [SerializeField]
        // ReSharper disable once NotAccessedField.Local
        private MeshRendererComponent meshRendererComponent;

        [SerializeField]
        // ReSharper disable once NotAccessedField.Local
        private ShaderComponent shaderComponent;

        public IShaderComponent ShaderComponent => shaderComponent;

        public IRenderingComponent RenderingComponent => meshRendererComponent;
    }
}