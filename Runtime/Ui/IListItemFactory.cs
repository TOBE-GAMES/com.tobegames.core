namespace Tobe.Core
{
    public interface IListItemFactory
    {
        TItem Create<TItem>() where TItem : class;
    }

    public class ListItemFactory : IListItemFactory
    {
        private readonly UiLabelControllerProxy.Factory _uiLabelFactory;

        public ListItemFactory(UiLabelControllerProxy.Factory uiLabelFactory)
        {
            _uiLabelFactory = uiLabelFactory;
        }

        public TItem Create<TItem>() where TItem : class
        {
            if (typeof(TItem) == typeof(UiLabelControllerProxy))
                return _uiLabelFactory.Create() as TItem;
            
            throw new System.NotImplementedException();
        }
    }
}