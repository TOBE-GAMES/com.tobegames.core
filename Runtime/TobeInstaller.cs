using Zenject;

namespace Tobe.Core
{
    public class TobeInstaller : MonoInstaller
    {
        public UiLabelComponent prefab;


        public UiViewPrefabRepository uiViewPrefab;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<JsonSerializationService>().AsSingle();

            Container.BindInterfacesAndSelfTo<XmlSerializationProvider>().AsSingle();

            Container.BindInterfacesAndSelfTo<SimpleObjectManager>().AsTransient();

            Container.BindFactory<ISimpleObjectView, SimpleObjectManager, SimpleObjectManagerProxy.Factory>()
                .AsSingle();

            Container.BindInterfacesAndSelfTo<ListItemFactory>().AsSingle();
            Container.BindInterfacesAndSelfTo<UiViewFactory>().AsSingle();

            Container.BindInterfacesAndSelfTo<CardViewService>().AsSingle();

            Container.BindFactory<CardView, CardView.Factory>().FromComponentInNewPrefab(uiViewPrefab.cardViewPrefab)
                .AsSingle();
            Container.BindFactory<UiLabelComponent, UiLabelComponent.Factory>().FromComponentInNewPrefab(prefab)
                .AsSingle();

            Container.BindInterfacesAndSelfTo<ListManager>().AsSingle();
        }
    }
}