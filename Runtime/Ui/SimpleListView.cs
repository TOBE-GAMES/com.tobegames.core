using UnityEngine;

namespace Tobe.Core
{
    [RequireComponent(typeof(SimpleListManagerProxy))]
    public class SimpleListView : ListView<string>
    {
        [SerializeField]
        private MonoDataSource monoDataSource;

        public override IDataSource<string> DataSource => monoDataSource;
    }
}