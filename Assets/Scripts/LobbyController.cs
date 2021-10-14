using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FoxC
{
    public class LobbyController : MonoBehaviour
    {
        [SerializeField]
        private GameSettingsView _gameSettingsView;

        [SerializeField]
        private ButtonsView _buttonsView;

        private void Awake()
        {
            Player.Current = new Player();
        }
    }
}