using Teams;
using UnityEngine;
using Words;
using Zenject;

namespace Engine.Installers
{
    [CreateAssetMenu(menuName = "DatabasesSO/Installers/DatabasePrefabsInstaller")]
    public class DatabasePrefabsInstaller : ScriptableObjectInstaller
    {
        [SerializeField] private TeamsNameDatabase _teamsNameDatabase;
        [SerializeField] private WordsDatabase _wordsDatabase;
        public override void InstallBindings()
        {
            Teams();
            Container.BindInstance(_wordsDatabase);
        }

        private void Teams()
        {
            Container.BindInstance(_teamsNameDatabase);
        }
    }
}