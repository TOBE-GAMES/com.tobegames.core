using UnityEngine;

namespace Plugins.TobeCore.Interactions
{
    public class SelectionGroup : MonoBehaviour
    {
        public Selectable[] items;

        public void Select()
        {
            foreach (var selectable in items)
            {
                selectable.Select(false);
            }
        }

        public void Deselect()
        {
            foreach (var selectable in items)
            {
                selectable.Deselect(false);
            }
        }
    }
}