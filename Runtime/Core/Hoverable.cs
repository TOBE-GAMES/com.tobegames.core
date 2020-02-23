using UnityEngine;

namespace Plugins.TobeCore.Interactions
{
    public abstract class Hoverable : MonoBehaviour
    {
        public HoverableEventHandler onHoverEnter;
        public HoverableEventHandler onHoverExit;

        public virtual void InvokeOnHoverEnter()
        {
            print("Hover Enter " + this);

            onHoverEnter?.Invoke(this);
        }
        
        public virtual void InvokeOnHoverExit()
        {
            print("Hover exits " + this);
            onHoverEnter?.Invoke(this);
        }
    }
}