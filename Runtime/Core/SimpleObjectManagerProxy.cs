using System.IO;
using Zenject;

namespace Tobe.Core
{
    public class SimpleObjectManagerProxy : ManagerProxy<SimpleObjectManager, ISimpleObjectView>, ISimpleObjectManager
    {
        public class Factory : PlaceholderFactory<ISimpleObjectView, SimpleObjectManager>
        {
            public override SimpleObjectManager Create(ISimpleObjectView param)
            {
                return new SimpleObjectManager(param);
            }
        }

        public void Hide()
        {
            Manager.Hide();
        }

        public void Show()
        {
            Manager.Show();
        }

        public void ToggleVisible()
        {
            Manager.ToggleVisible();
        }

        protected override SimpleObjectManager GetManager(DiContainer container)
        {
            return container.Resolve<Factory>().Create(View);
        }
    }
}