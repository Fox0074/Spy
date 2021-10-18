using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FoxC
{
    public class ButtonsView : WindowView
    {
        public Action OnPlayButtonClick = delegate { };
        public Action OnRulesButtonClick = delegate { };

        [SerializeField]
        private Button _playButton;

        [SerializeField]
        private Button _rulesButton;

        [SerializeField]
        private Button _addLocationButton;

        [SerializeField]
        private Button _rateUsButton;

        protected override void Awake()
        {
            base.Awake();
            _playButton.onClick.AddListener(OnPlayButtonClick.Invoke);
            _rulesButton.onClick.AddListener(OnRulesButtonClick.Invoke);
        }
    }
}