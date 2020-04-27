using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Tobe.Core
{
    public interface ICardHeader : IPanelComponent
    {
        IUiLabelComponent Title { get; }
    }

    public interface ICardBody : IPanelComponent
    {
        IUiLabelComponent Content { get; }
    }

    public interface ICardFooter : IPanelComponent
    {
        IUiLabelComponent Content { get; }
    }


    [RequireComponent(typeof(CanvasGroup))]
    public class PanelComponent : MonoComponent, IPanelComponent
    {
        private CanvasGroup _canvasGroup;

        private Image _backgroundImage;

        private void Start()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
            _backgroundImage = GetComponent<Image>();
        }

        public bool IsVisible => _canvasGroup.alpha > 0;

        public void Show()
        {
            _canvasGroup.alpha = 1;
            _canvasGroup.blocksRaycasts = _canvasGroup.interactable = true;
        }

        public void Hide()
        {
            _canvasGroup.alpha = 0;
            _canvasGroup.blocksRaycasts = _canvasGroup.interactable = false;
        }

        public Color Color
        {
            get => _backgroundImage != null ? _backgroundImage.color : Color.black;
            set
            {
                if (_backgroundImage)
                {
                    _backgroundImage.color = value;
                }
            }
        }
    }
}