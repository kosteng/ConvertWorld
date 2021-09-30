using System;

namespace Words
{
    [Serializable]
    public class WordModel
    {
        public string Title;
        public string Description;
        public EWordStatusType WordStatus;
    }
}