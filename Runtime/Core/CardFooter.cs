using UnityEngine;

namespace Tobe.Core
{
    public class CardFooter : PanelComponent, ICardFooter
    {
        [SerializeField] private UiLabelComponent content;

        public IUiLabelComponent Content => content;
    }
}