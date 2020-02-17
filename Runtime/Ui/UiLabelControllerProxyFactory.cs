using UnityEngine;

namespace Tobe.Core
{
    public class UiLabelControllerProxyFactory : IPrefabFactory<UiLabelControllerProxy>
    {
        
        
        private readonly IPrefabRepository _prefabRepository;

        public UiLabelControllerProxyFactory(IPrefabRepository prefabRepository)
        {
            _prefabRepository = prefabRepository;
        }

        public UiLabelControllerProxy Create()
        {
            return Object.Instantiate(_prefabRepository.GetPrefab<UiLabelControllerProxy>());
        }
    }
}