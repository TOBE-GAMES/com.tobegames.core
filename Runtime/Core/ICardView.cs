namespace Tobe.Core
{
    public interface ICardView : IUiView<SimpleCardModel>
    {
        ICardHeader Header { get; }
        
        ICardBody Body { get; }
        
        ICardFooter Footer { get; }

        IUiImageComponent Background { get; }
    }
}