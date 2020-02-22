namespace Tobe.Core
{
    public class SimpleObjectManager : ISimpleObjectManager
    {
        private readonly ISimpleObjectView _view;

        public SimpleObjectManager(ISimpleObjectView view)
        {
            _view = view;
        }

        public void Hide()
        {
            _view.RenderingComponent.SetVisible(false);
        }

        public void Show()
        {
            _view.RenderingComponent.SetVisible(true);
        }

        public void Activate()
        {
            _view.RenderingComponent.SetActive(true);
        }

        public void Deactivate()
        {
            _view.RenderingComponent.SetActive(false);
        }

        public void ToggleVisible()
        {
            _view.RenderingComponent.ToggleVisible();
        }
    }
}