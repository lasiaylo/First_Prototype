using System;
using System.Collections.Generic;
using UnityEngine;

namespace States {
    public class StateMachine {
        private IPlayerState _currentPlayerState;
        private PlayerController _player;

        public StateMachine(PlayerController player) {
            _player = player;
        }

        public StateMachine(PlayerController player, IPlayerState initialPlayerState) : this(player) {
            SetState(initialPlayerState);
        }

        public void SetState(IPlayerState playerState)  {
            _currentPlayerState?.Exit(TODO);
            _currentPlayerState = playerState;
            _currentPlayerState.Enter(TODO);
        }

        public void Update() {
            _currentPlayerState.Update(TODO);
        }

        public void FixedUpdate() {
            _currentPlayerState.FixedUpdate(TODO);
        }
    }
}