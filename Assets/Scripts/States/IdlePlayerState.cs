using UnityEngine;

namespace States {
    public class IdlePlayerState : IPlayerState {
        private TestStateMachine _tsm;

        public IdlePlayerState(TestStateMachine tsm) {
            _tsm = tsm;
        }
        public void Enter(PlayerController player) {
        }

        public void Update(PlayerController player) {
            _tsm.SetState(new RunningPlayerState(_tsm));
        }

        public void FixedUpdate(PlayerController player) {
        }

        public void Exit(PlayerController player) {
        }
    }

    public class RunningPlayerState : IPlayerState {
        private TestStateMachine _tsm;

        public RunningPlayerState(TestStateMachine tsm) {
            _tsm = tsm;
        }
        public void Enter(PlayerController player) {
        }

        public void Update(PlayerController player) {
            _tsm.SetState(new IdlePlayerState(_tsm));
        }

        public void FixedUpdate(PlayerController player) {
        }

        public void Exit(PlayerController player) {
        }
    }
}