using UnityEngine;
using UnityEngine.UI;

namespace Tobe.Core
{
    public class UiImageComponent : MonoComponent, IUiImageComponent
    {
        private Image _backgroundImage;

        protected override void OnAwake()
        {
            _backgroundImage = GetComponent<Image>();
        }

        public override void SetEnabled(bool value)
        {
            base.SetEnabled(value);
            _backgroundImage.enabled = value;
        }

        public Color Color
        {
            get => _backgroundImage != null ? _backgroundImage.color : Color.black;
            set
            {
                if (_backgroundImage)
                    _backgroundImage.color = value;
            }
        }
    }
}