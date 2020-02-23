using UnityEngine;

namespace Plugins.TobeCore.Interactions
{
    public class SelectableChild : Selectable
    {
        [Tooltip("If null, get from parent")] public Selectable parent;

        void Start()
        {
            if (!parent)
            {
                parent = GetComponentInParent<Selectable>();
            }
        }

        public override void Select(bool propagateToGroup = false)
        {
            parent.SelectedFromChild(this, propagateToGroup);
        }

        public override void Deselect(bool propagateToGroup = false)
        {
            parent.DeselectFromChild(this, propagateToGroup);
        }
    }
}