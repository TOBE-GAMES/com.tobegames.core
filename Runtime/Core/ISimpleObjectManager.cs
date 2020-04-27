namespace Tobe.Core
{
    public interface ISimpleObjectManager : IManager
    {
        void Hide();

        void Show();

        void ToggleVisible();
    }
}