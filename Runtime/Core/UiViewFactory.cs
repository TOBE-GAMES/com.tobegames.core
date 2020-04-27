namespace Tobe.Core
{
    class UiViewFactory : IUiViewFactory
    {
        private readonly CardView.Factory _factory;

        public UiViewFactory(CardView.Factory factory)
        {
            _factory = factory;
        }

        public ICardView CreateCardView(SimpleCardModel model)
        {
            var instance = _factory.Create();
            
            return instance;
        }
    }
}