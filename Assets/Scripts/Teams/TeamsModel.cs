namespace Teams
{
    public class TeamsModel
    {
        private string _name;
        private int _scores;
        public string Name => _name;
        public int Scores => _scores;

        public TeamsModel(string name)
        {
            _name = name;
        }

        public void AddScores(int value)
        {
            _scores += value;
        }
    }
}
