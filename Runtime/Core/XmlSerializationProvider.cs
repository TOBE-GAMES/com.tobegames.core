namespace Tobe.Core
{
    public class XmlSerializationProvider : IXmlSerializationProvider
    {
        public IXmlSerializationService<TModel> ProvideSerializationService<TModel>() where TModel : class
        {
            return new XmlSerializationService<TModel>();
        }
    }
}