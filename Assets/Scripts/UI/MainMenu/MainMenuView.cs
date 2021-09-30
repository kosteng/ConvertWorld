using System;
using Engine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.BottomPanel
{
    public class MainMenuView : APanel
    {
        [SerializeField] private Button _randomNameButton;
        [SerializeField] private Button _addTeamButton;
        [SerializeField] private Button _printButton;
        [SerializeField] private TMP_InputField _teamsName;

        public void Subscribe(Action onOpen, Action onRandom, Action<string> AddCallBack, Action OnPrint)
        {
            _randomNameButton.onClick.AddListener(onRandom.Invoke);
            _addTeamButton.onClick.AddListener(() => AddCallBack?.Invoke(_teamsName.text));
            _printButton.onClick.AddListener(OnPrint.Invoke);
        }

        public void Unsubscribe()
        {
            _randomNameButton.onClick.RemoveAllListeners();
            _addTeamButton.onClick.RemoveAllListeners();
            _printButton.onClick.RemoveAllListeners();
        }

        public void SetInputText(string value)
        {
            _teamsName.text = value;
        }

        public void ClearInput()
        {
            _teamsName.text = string.Empty;
        }
    }
}