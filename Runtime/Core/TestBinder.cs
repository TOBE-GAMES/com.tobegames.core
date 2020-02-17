using UnityEngine;

namespace Tobe.Core
{
    public class TestBinder : ListDataBinder<string, UiLabelControllerProxy>
    {
        [SerializeField] private SimpleListView _simpleListView;

        [SerializeField] private SimpleListControllerProxy _controller;

        protected override IListView<string> View => _simpleListView;
        
        protected override IListController Controller => _controller;

        protected override void Bind(string model, UiLabelControllerProxy item)
        {
            item.SetText(model);
        }
    }
}