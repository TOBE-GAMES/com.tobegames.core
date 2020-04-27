using System;

namespace Tobe.Core
{
    public enum ModelStrategy
    {
        IfModelIsDirty,
        EachUpdate
    }
  
    [Serializable]
    public class SimpleCardModel
    {
        public string title;
        
        public string body;
        
        public string footer;
    }
}