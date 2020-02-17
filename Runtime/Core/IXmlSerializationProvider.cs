namespace Tobe.Core
{
    public interface IXmlSerializationProvider
    {
        IXmlSerializationService<TModel> ProvideSerializationService<TModel>() where TModel : class;
    }
}