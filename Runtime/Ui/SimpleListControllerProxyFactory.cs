using UnityEngine;
using Zenject;

namespace Tobe.Core
{
    public class SimpleListControllerProxyFactory : IFactory<UiLabelComponent>
    {
        private readonly UiLabelComponent _prefab;

        public SimpleListControllerProxyFactory(UiLabelComponent prefab)
        {
            _prefab = prefab;
        }

        public UiLabelComponent Create()
        {
            return Object.Instantiate(_prefab);
        }
    }
}