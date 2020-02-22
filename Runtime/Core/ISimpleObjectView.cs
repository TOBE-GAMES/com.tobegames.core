namespace Tobe.Core
{
    public interface ISimpleObjectView : IView
    {
        IRenderingComponent RenderingComponent { get; }
    }
}