using UnityEngine;

namespace Plugins.TobeCore.Interactions
{
    public class HoverableChild : Hoverable
    {
        public HoverableRoot hoverableRoot;

        public override void InvokeOnHoverEnter()
        {
            if (hoverableRoot)
            {
                hoverableRoot.InvokeOnHoverEnter();
            }
            else
            {
                base.InvokeOnHoverEnter();
            }
        }

        public override void InvokeOnHoverExit()
        {
            if (hoverableRoot)
            {
                hoverableRoot.InvokeOnHoverExit();
            }
            else
            {
                base.InvokeOnHoverExit();
            }
        }
    }
}