using Zenject;

namespace Tobe.Core
{
    public class SimpleObjectManagerProxy : ManagerProxy<SimpleObjectManager, ISimpleObjectView>, ISimpleObjectManager
    {
        public void Hide()
        {
            Manager.Hide();
        }

        public void Show()
        {
            Manager.Show();
        }

        public void Activate()
        {
            Manager.Activate();
        }

        public void Deactivate()
        {
            Manager.Deactivate();
        }

        public void ToggleVisible()
        {
            Manager.ToggleVisible();
        }

        protected override SimpleObjectManager GetManager(DiContainer container)
        {
            return container.Instantiate<SimpleObjectManager>(new[] {View});
        }
    }
}