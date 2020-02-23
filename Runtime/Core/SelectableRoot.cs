using System;
using UnityEngine;
using UnityEngine.Events;

namespace Plugins.TobeCore.Interactions
{
    [Serializable]
    public class SelectableOnSelectionChangedEvent : UnityEvent<Selectable>
    {
    }

    public class SelectableRoot : Selectable
    {
        [Tooltip("If null, get from parent")] public SelectionGroup selectionGroup;

        private SelectableChild _selectedChild;

        public SelectableOnSelectionChangedEvent onSelectionChanged;

        private void Start()
        {
            if (!selectionGroup)
            {
                selectionGroup = gameObject.GetComponentInParent<SelectionGroup>();
            }
        }

        public override void Select(bool propagateToGroup = false)
        {
            if (selectionGroup && propagateToGroup)
            {
                selectionGroup.Select();
            }
            else
            {
                onSelectionChanged?.Invoke(this);
                Selected = true;
            }
        }

        public override void Deselect(bool propagateToGroup = false)
        {
            if (selectionGroup && propagateToGroup)
            {
                selectionGroup.Deselect();
            }
            else
            {
                onSelectionChanged?.Invoke(this);
                Selected = false;
            }
        }

        public override void DeselectFromChild(SelectableChild child, bool propagateToGroup = false)
        {
            _selectedChild = null;
            Deselect(propagateToGroup);
        }

        public override void SelectedFromChild(SelectableChild child, bool propagateToGroup = false)
        {
            _selectedChild = child;
            Select(propagateToGroup);
        }
    }
}