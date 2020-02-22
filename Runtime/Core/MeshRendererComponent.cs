using UnityEngine;

namespace Tobe.Core
{
    [RequireComponent(typeof(MeshRenderer))]
    public class MeshRendererComponent : MonoBehaviour, IRenderingComponent
    {
        private MeshRenderer _meshRenderer;

        private void Awake()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        public bool GetActive()
        {
            return gameObject.activeSelf;
        }

        public void SetActive(bool value)
        {
            gameObject.SetActive(value);
        }

        public void ToggleActive()
        {
            SetActive(!GetActive());
        }

        public bool GetVisible()
        {
            return _meshRenderer.enabled;
        }

        public void SetVisible(bool value)
        {
            _meshRenderer.enabled = value;
        }

        public void ToggleVisible()
        {
            SetActive(!GetActive());
        }
    }
}