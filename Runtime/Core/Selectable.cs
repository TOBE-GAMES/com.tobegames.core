using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Plugins.TobeCore.Interactions
{
    public abstract class Selectable : MonoBehaviour
    {
        public bool Selected { get; protected set; }

        public virtual void ToggleSelect(bool propagateToGroup = false)
        {
            if (Selected)
            {
                Deselect(propagateToGroup);
            }
            else
            {
                Select(propagateToGroup);
            }
        }

      
        public virtual void Select(bool propagateToGroup = false)
        {
            Selected = true;
        }


        public virtual void Deselect(bool propagateToGroup = false)
        {

            Selected = false;
        }

        public virtual void SelectedFromChild(SelectableChild child, bool propagateToGroup = false)
        {
            Selected = true;
        }


        public virtual void DeselectFromChild(SelectableChild child, bool propagateToGroup = false)
        {
            Selected = false;
        }
    }
}