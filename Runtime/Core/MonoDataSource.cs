using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace Tobe.Core
{
    public class MonoDataSource : MonoBehaviour, IDataSource<string>
    {
        public string[] data;

        public IEnumerable<string> GetData()
        {
            return data;
        }
    }
    
    
    
}