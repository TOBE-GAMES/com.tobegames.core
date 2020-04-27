using UnityEngine;

namespace Tobe.Core
{
    [RequireComponent(typeof(MeshRenderer))]
    public class MeshRendererComponent : MonoComponent, IRenderingComponent
    {
        private MeshRenderer _meshRenderer;

        private void Awake()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        public override bool GetEnabled()
        {
            return _meshRenderer.enabled;
        }

        public override void SetEnabled(bool value)
        {
            base.SetEnabled(value);
            _meshRenderer.enabled = value;
        }
    }
}