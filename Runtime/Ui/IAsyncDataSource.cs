using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Tobe.Core
{
    public interface IAsyncDataSource<TDataModel>
    {
        Task<IEnumerable<TDataModel>> GetData();
    }
}