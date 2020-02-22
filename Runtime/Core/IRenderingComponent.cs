namespace Tobe.Core
{
    public interface IRenderingComponent : IComponent
    {
        bool GetVisible();        
        void SetVisible(bool value);
        void ToggleVisible();
    }
}