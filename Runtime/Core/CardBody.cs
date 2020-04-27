using UnityEngine;

namespace Tobe.Core
{
    public class CardBody : PanelComponent, ICardBody
    {
        [SerializeField] private UiLabelComponent content;
        public IUiLabelComponent Content => content;
    }
}