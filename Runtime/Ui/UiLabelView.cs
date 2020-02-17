using TMPro;
using UnityEngine;

namespace Tobe.Core
{
    public class UiLabelView : MonoView<IUiLabelView>, IUiLabelView
    {
        [SerializeField] private TextMeshProUGUI _label;

        public string Text
        {
            get => _label.text;
            set => _label.text = value;
        }
    }
}