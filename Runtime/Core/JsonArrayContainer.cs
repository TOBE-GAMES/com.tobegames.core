using System;

namespace Tobe.Core
{
    [Serializable]
    public class JsonArrayContainer<TModel>
    {
        public TModel[] data;
    }
}