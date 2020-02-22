using TMPro;
using UnityEngine;
using Zenject;

namespace Tobe.Core
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public partial class UiLabelComponent : MonoComponent, IUiLabelComponent
    {
         private TextMeshProUGUI _label;

         protected override void OnAwake()
         {
             _label = GetComponent<TextMeshProUGUI>();
         }

         public class Factory : PlaceholderFactory<UiLabelComponent>
        {
            
        }
        
        public string Text
        {
            get => _label.text;
            set => _label.text = value;
        }

        public bool GetVisible()
        {
            return _label.enabled;
        }

        public void SetVisible(bool value)
        {
            _label.enabled = value;
        }

        public void ToggleVisible()
        {
            SetVisible(!GetVisible());
        }
    }
}