namespace Tobe.Core
{
    public interface IJsonSerializationService
    {
        string Serialize<TModel>(TModel data);
        string Serialize<TModel>(TModel[] data);
        TModel Deserialize<TModel>(string json);
        TModel[] DeserializeArray<TModel>(string json);
    }
}