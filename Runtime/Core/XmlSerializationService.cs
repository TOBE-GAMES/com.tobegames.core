using System.IO;
using System.Xml.Serialization;

namespace Tobe.Core
{
    
    
    public class XmlSerializationService<TModel> : IXmlSerializationService<TModel> where TModel : class
    {
        private readonly XmlSerializer _serializer;

        public XmlSerializationService()
        {
            _serializer = new XmlSerializer(typeof(TModel));
        }

        public void Serialize(Stream stream, TModel data)
        {
            _serializer.Serialize(stream, data);
        }

        public TModel Deserialize(Stream stream)
        {
            return _serializer.Deserialize(stream) as TModel;
        }
    }
}