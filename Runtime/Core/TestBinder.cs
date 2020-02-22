using UnityEngine;

namespace Tobe.Core
{
    #pragma warning disable 0649

    public class TestBinder : ListDataBinder<string, UiLabelComponent>
    {
        [SerializeField] private SimpleListView simpleListView;

        [SerializeField] private SimpleListManagerProxy manager;

        protected override IListView<string> View => simpleListView;

        protected override IListManager Manager => manager;

        protected override void Bind(string model, UiLabelComponent item)
        {
            item.Text = model;
        }
    }
}