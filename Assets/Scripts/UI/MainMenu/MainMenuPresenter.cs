using System;
using Engine.UI;
using Teams;
using UnityEngine;
using Zenject;
using Random = System.Random;

namespace UI.BottomPanel
{
    public class MainMenuPresenter : IDisposable, IAttachableUi, IInitializable
    {
        private readonly MainMenuView _view;
        private readonly TeamsNameDatabase _nameDatabase;
        private readonly ITeamsController _teamsController;

        private Random _random = new Random();
        private string _randomName = string.Empty;
        private int _prevElement = -1;

        public MainMenuPresenter(MainMenuView view, TeamsNameDatabase nameDatabase, ITeamsController teamsController)
        {
            _view = view;
            _nameDatabase = nameDatabase;
            _teamsController = teamsController;
        }

        private void Show()
        {
        }

        public void Dispose()
        {
            _view.Unsubscribe();
        }

        public void Attach(Transform parent)
        {
            _view.Attach(parent);
        }

        public void Initialize()
        {
            _view.Subscribe(Show, OnRandomNameClick, OnAddTeamClick, OnPrintClick);
        }

        private void OnPrintClick()
        {
            _teamsController.PrintNameTeams();
        }

        private void OnAddTeamClick(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Debug.Log("String is empty");
                return;
            }
            
            if ((_teamsController.TryGetUniqueName(name)))
                _teamsController.AddTeam(name);
            else
                Debug.Log($"Can`t use twice {name}");
            
            _view.ClearInput();
        }

        private void OnRandomNameClick()
        {
            var index = _random.Next(0, _nameDatabase.Names.Length);

            while (index == _prevElement)
            {
                index = _random.Next(0, _nameDatabase.Names.Length);
            }

            _prevElement = index;
            _randomName = _nameDatabase.Names[index];
            _view.SetInputText(_randomName);
        }
    }
}