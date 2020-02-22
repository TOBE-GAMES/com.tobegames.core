using Zenject;

namespace Tobe.Core
{
    public class TobeInstaller : MonoInstaller
    {
        public UiLabelComponent prefab;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<JsonSerializationService>().AsSingle();

            Container.BindInterfacesAndSelfTo<XmlSerializationProvider>().AsSingle();

            Container.BindInterfacesAndSelfTo<SimpleObjectManager>().AsTransient();
            
            
            Container.BindInterfacesAndSelfTo<ListItemFactory>().AsSingle();
            
            Container.BindFactory<UiLabelComponent, UiLabelComponent.Factory>()
                .FromComponentInNewPrefab(prefab).AsSingle();

            Container.BindInterfacesAndSelfTo<ListManager>().AsSingle();
        }
    }
}