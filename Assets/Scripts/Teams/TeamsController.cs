using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Teams
{
    public interface ITeamsController
    {
        void AddTeam(string name);
        void PrintNameTeams();
        TeamsModel GetNextTeam();
        bool TryGetUniqueName(string newName);
    }
    
    public class TeamsController : ITeamsController
    {
        private List<TeamsModel> _teams = new List<TeamsModel>(4);
        private int _currentTeam;
        
        public TeamsModel GetNextTeam()
        {
            return _teams[_currentTeam++];
        }

        public bool TryGetUniqueName(string newName)
        {
            return _teams.All(team => newName != team.Name);
        }

        public void AddTeam(string name)
        {
            _teams.Add(new TeamsModel(name));
        }
        
        public void PrintNameTeams()
        {
            foreach (var team in _teams)
            {
                Debug.Log(team.Name);
            }
        }
    }
}
