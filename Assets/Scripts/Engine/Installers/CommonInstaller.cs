using Engine.Mediators;
using Engine.UI.Canvas;
using Teams;
using UI.BottomPanel;
using Zenject;

namespace Engine.Installers
{
    public class CommonInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Mediators();
            Ui();
            Container.BindInterfacesAndSelfTo<TeamsController>().AsSingle();
        }
        
        private void Mediators()
        {
            Container.BindInterfacesTo<UnityEventMediator>().AsSingle().NonLazy();
        }

        private void Ui()
        {
            Container.BindInterfacesTo<CanvasContainer>().AsSingle();
            Container.BindInterfacesTo<UI.UiAttachSystem.UiAttachSystem>().AsSingle();
            Container.BindInterfacesAndSelfTo<MainMenuPresenter>().AsSingle();
        }
    }
}
