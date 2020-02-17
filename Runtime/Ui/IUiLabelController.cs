namespace Tobe.Core
{
    public interface IUiLabelController : IController
    {
        void SetText(IUiLabelView view, string value);
    }
}