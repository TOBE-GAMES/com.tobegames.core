namespace Tobe.Core
{
    public interface IComponent
    {

        bool GetEnabled();        
        
        void SetEnabled(bool value);
        
        void ToggleEnabled();
    }
}