using UnityEngine;
using Zenject;

namespace Tobe.Core
{
    public class SimpleListControllerProxyFactory : IFactory<UiLabelControllerProxy>
    {
        private readonly UiLabelControllerProxy _prefab;

        public SimpleListControllerProxyFactory(UiLabelControllerProxy prefab)
        {
            _prefab = prefab;
        }

        public UiLabelControllerProxy Create()
        {
            return Object.Instantiate(_prefab);
        }
    }
}