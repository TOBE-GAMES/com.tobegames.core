using Zenject;

namespace Tobe.Core
{
    public class UiLabelControllerProxy : MonoControllerProxy<UiLabelController, UiLabelView>
    {
        public class Factory : PlaceholderFactory<UiLabelControllerProxy>
        {
            
        }
        
      public void SetText(string value)
        {
            Controller.SetText(View, value);
        }
    }
}