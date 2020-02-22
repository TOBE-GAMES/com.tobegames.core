namespace Tobe.Core
{
    public interface IListItemFactory
    {
        TItem Create<TItem>() where TItem : class;
    }

    public class ListItemFactory : IListItemFactory
    {
        private readonly UiLabelComponent.Factory _uiLabelFactory;

        public ListItemFactory(UiLabelComponent.Factory uiLabelFactory)
        {
            _uiLabelFactory = uiLabelFactory;
        }

        public TItem Create<TItem>() where TItem : class
        {
            if (typeof(TItem) == typeof(UiLabelComponent))
                return _uiLabelFactory.Create() as TItem;
            
            throw new System.NotImplementedException();
        }
    }
}