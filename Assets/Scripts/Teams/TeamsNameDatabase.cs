using UnityEngine;

namespace Teams
{
    [CreateAssetMenu(menuName = "DatabasesSO/TeamsName")]
    public class TeamsNameDatabase : ScriptableObject
    {
        [SerializeField]private string[] _names;
        public string[] Names => _names;
    }
}
