using Zenject;

namespace Tobe.Core
{
    public interface IPrefabFactoryProvider
    {
        IPrefabFactory<TPrefabModel> ProvideFactory<TPrefabModel>();
    }

    public interface IPrefabFactory<out TPrefab>
    {
        TPrefab Create();
    }

    public interface IPrefabRepository
    {
        TPrefab GetPrefab<TPrefab>() where TPrefab : class;
    }

    public class ListPrefabRepository : IPrefabRepository
    {
        private readonly UiLabelControllerProxy _uiLabelControllerProxy;

        public ListPrefabRepository(UiLabelControllerProxy uiLabelControllerProxy)
        {
            _uiLabelControllerProxy = uiLabelControllerProxy;
        }

        public TPrefab GetPrefab<TPrefab>() where TPrefab : class
        {
            if (typeof(TPrefab) == typeof(UiLabelControllerProxy))
                return _uiLabelControllerProxy as TPrefab;

            return null;
        }
    }
    
    public class PrefabFactoryProvider : IPrefabFactoryProvider
    {

        private readonly DiContainer _diContainer;

        public PrefabFactoryProvider(DiContainer diContainer)
        {
            _diContainer = diContainer;
        }

        public IPrefabFactory<TPrefabModel> ProvideFactory<TPrefabModel>()
        {
            return _diContainer.Resolve<IPrefabFactory<TPrefabModel>>();
        }
    }
}