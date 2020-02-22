namespace Tobe.Core
{
    public interface IComponent
    {

        bool GetActive();        
        void SetActive(bool value);
        void ToggleActive();

    }
}