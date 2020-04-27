namespace Tobe.Core
{
    public interface IPanelComponent : IRenderingComponent, IUiBackgroundRenderer
    {
        bool IsVisible { get; }
        void Show();
        void Hide();
    }
}