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
            _view.RenderingComponent.SetEnabled(false);
        }

        public void Show()
        {
            _view.RenderingComponent.SetEnabled(true);
        }

      
        public void ToggleVisible()
        {
            _view.RenderingComponent.ToggleEnabled();
        }
    }
}