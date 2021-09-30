using UnityEngine;

namespace Words
{
    [CreateAssetMenu(menuName = "DatabasesSO/WordsData")]
    public class WordsDatabase : ScriptableObject
    {
        [SerializeField]private WordModel[] _words;
        public WordModel[] Words => _words;
    }
}