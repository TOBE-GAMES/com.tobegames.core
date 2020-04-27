using UnityEngine;

namespace Tobe.Core
{
    public class CardHeader : PanelComponent, ICardHeader
    {
        [SerializeField]
        private UiLabelComponent title;

        public IUiLabelComponent Title => title;
    }
}