namespace Tobe.Core
{
    public interface IUiViewFactory
    {
        ICardView CreateCardView(SimpleCardModel model);
    }
}