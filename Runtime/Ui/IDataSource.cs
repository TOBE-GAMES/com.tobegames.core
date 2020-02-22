using System.Collections.Generic;

namespace Tobe.Core
{
    public interface IDataSource<out TDataModel>
    {
        IEnumerable<TDataModel> GetData();
    }
}