using UnityEngine;

namespace Tobe.Core
{
    [RequireComponent(typeof(SimpleListControllerProxy))]
    public class SimpleListView : ListView<string>
    {
        public string[] data;

        public override string[] Data => data;

        [SerializeField]
        private MonoDataSource monoDataSource;

        public override IAsyncDataSource<string> DataSource => monoDataSource;
    }
}