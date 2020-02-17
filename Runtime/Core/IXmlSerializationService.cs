using System.IO;

namespace Tobe.Core
{
    public interface IXmlSerializationService<TModel> where TModel : class
    {
        void Serialize(Stream stream, TModel data);

        TModel Deserialize(Stream stream);
    }
}