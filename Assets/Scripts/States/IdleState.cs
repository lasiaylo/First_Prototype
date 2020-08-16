using UnityEngine;

namespace States {
    public class IdleState : IState {
        private TestStateMachine _tsm;

        public IdleState(TestStateMachine tsm) {
            _tsm = tsm;
        }
        public void Enter() {
        }

        public void Update() {
            _tsm.SetState(new RunningState(_tsm));
        }

        public void FixedUpdate() {
        }

        public void Exit() {
        }
    }

    public class RunningState : IState {
        private TestStateMachine _tsm;

        public RunningState(TestStateMachine tsm) {
            _tsm = tsm;
        }
        public void Enter() {
        }

        public void Update() {
            _tsm.SetState(new IdleState(_tsm));
        }

        public void FixedUpdate() {
        }

        public void Exit() {
        }
    }
}