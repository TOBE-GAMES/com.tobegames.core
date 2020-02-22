using System;

namespace Tobe.Core
{
    [Serializable]
    public sealed class ShaderModelParam
    {
        public string Name { get; set; }
        public object Value { get; set; }
    }
}