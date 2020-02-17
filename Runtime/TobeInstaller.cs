using Zenject;

namespace Tobe.Core
{
    public class TobeInstaller : MonoInstaller
    {
        public UiLabelControllerProxy prefab;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<JsonSerializationService>().AsSingle();

            Container.BindInterfacesAndSelfTo<XmlSerializationProvider>().AsSingle();

           // Container.BindInterfacesAndSelfTo<PrefabFactoryProvider>().AsSingle();

            //Container.Bind<IPrefabFactory<UiLabelControllerProxy>>().To<UiLabelControllerProxyFactory>().AsSingle();

            //Container.BindInterfacesAndSelfTo<ListPrefabRepository>().FromInstance(new ListPrefabRepository(prefab)).AsSingle();

            Container.BindInterfacesAndSelfTo<ListItemFactory>().AsSingle();
            
            Container.BindFactory<UiLabelControllerProxy, UiLabelControllerProxy.Factory>()
                .FromComponentInNewPrefab(prefab).AsSingle();
            
            Container.BindInterfacesAndSelfTo<ListController>().AsSingle();

            Container.BindInterfacesAndSelfTo<UiLabelController>().AsSingle();
        }
    }
}