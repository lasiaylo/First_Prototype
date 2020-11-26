using Translate.Movement;
using UnityEngine;

namespace States.Player {
    [CreateAssetMenu(fileName = "JumpSquatState", menuName = "States/JumpSquat", order = 5)]
    public class JumpSquatState : MovableState {
        private MovementTicker _movementTicker;
        public override PlayerState PlayerState => PlayerState.JumpSquat;

        public override void Initialize(StateMachine newStateMachine) {
            base.Initialize(newStateMachine);
            _movementTicker = stateMachine.gameObject.GetComponent<MovementTicker>();
        }

        public override void Transition() {
            if (_movementTicker.Value.y <= 0 && !Controller.isGrounded) {
                Debug.Log("FALLING?");
                stateMachine.SetState<FallState>();
            }
        }

        public override void Invoke() {
            // Debug.Break();
            Debug.Log("INCOKES");
            stateMachine.SetState<JumpState>();
        }
    }
}