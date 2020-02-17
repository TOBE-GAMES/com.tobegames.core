namespace Tobe.Core
{
    public class UiLabelController : IUiLabelController
    {
        public void SetText(IUiLabelView view, string value)
        {
            view.Text = value;
        }
    }
}