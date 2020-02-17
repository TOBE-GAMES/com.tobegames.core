using UnityEngine;

namespace Tobe.Core
{
    public class JsonSerializationService : IJsonSerializationService
    {
        public string Serialize<TModel>(TModel data)
        {
            var result = JsonUtility.ToJson(data);

            return result;
        }

        public string Serialize<TModel>(TModel[] data)
        {
            var result = new JsonArrayContainer<TModel>() {data = data};

            return Serialize(result);
        }

        public TModel Deserialize<TModel>(string json)
        {
            return JsonUtility.FromJson<TModel>(json);
        }

        public TModel[] DeserializeArray<TModel>(string json)
        {
            var container = Deserialize<JsonArrayContainer<TModel>>(json);

            return container.data;
        }
    }
}