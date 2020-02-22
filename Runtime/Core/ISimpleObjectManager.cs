namespace Tobe.Core
{
    public interface ISimpleObjectManager : IManager
    {
        void Hide();

        void Show();

        void Activate();

        void Deactivate();

        void ToggleVisible();
    }
}