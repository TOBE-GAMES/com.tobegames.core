using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace Tobe.Core
{
    public class MonoDataSource : MonoBehaviour, IAsyncDataSource<string>
    {
        public string[] data;

        public Task<IEnumerable<string>> GetData()
        {
            return new Task<IEnumerable<string>>(() => data);
        }
    }
}