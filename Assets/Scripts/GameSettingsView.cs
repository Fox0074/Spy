using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

namespace FoxC
{
    public class GameSettingsView : WindowView
    {
        public Action OnPlayButtonClick = delegate { };

        [SerializeField]
        private TextMeshProUGUI _playersCounter;

        [SerializeField]
        private Button _plusPlayer;

        [SerializeField]
        private Button _minusPlayer;

        [SerializeField]
        private TextMeshProUGUI _spyCounter;

        [SerializeField]
        private Button _plusSpy;

        [SerializeField]
        private Button _minusSpy;

        [SerializeField]
        private Button _playButton;

        private int _players;
        private int _spys;

        protected override void Awake()
        {
            base.Awake();
            _plusPlayer.onClick.AddListener(() => SetPlayers(1));
            _minusPlayer.onClick.AddListener(() => SetPlayers(-1));

            _plusSpy.onClick.AddListener(() => SetSpys(1));
            _minusSpy.onClick.AddListener(() => SetSpys(-1));

            _playButton.onClick.AddListener(Play);
        }

        private void Initialize()
        {
            _players = Player.Current.PlayersCount;
            _spys = Player.Current.SpyCounts;
        }

        private void Play()
        {
            Save();
        }

        private void SetPlayers(int delta)
        {
            _players += delta;
            _players = Mathf.Min(2, _players);
        }

        private void SetSpys(int delta)
        {
            _spys += delta;
            _spys = Mathf.Min(1, _spys);
            _spys = Mathf.Max(_spys, _players - 1);
        }

        private void Save()
        {
            Player.Current.PlayersCount = _players;
            Player.Current.SpyCounts = _spys;
        }
    }
}