using Engine.UI;
using UI.BottomPanel;
using UnityEngine;
using Zenject;

namespace Engine.Installers
{
    [CreateAssetMenu(menuName = "DatabasesSO/Installers/UiPrefabsInstaller")]
    public class UiPrefabsInstaller : ScriptableObjectInstaller
    {
        [SerializeField] private CanvasView _canvasView;
        [SerializeField] private MainMenuView _mainMenuView;

        
        public override void InstallBindings()
        {
            Container.Bind<CanvasView>().FromComponentInNewPrefab(_canvasView).AsSingle();
            Container.Bind<MainMenuView>().FromComponentInNewPrefab(_mainMenuView).AsSingle();
        }
    }
}