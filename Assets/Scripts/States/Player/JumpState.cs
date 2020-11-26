using JetBrains.Annotations;
using ScriptableObjects.Prototypes.Trait;
using Translate.Movement;
using UnityEngine;

namespace States.Player {
    [CreateAssetMenu(fileName = "JumpState", menuName = "States/Jump", order = 2)]
    public class JumpState : AirState {
        public JumpTraits jump;
        private MovementTicker _movementTicker;
  
        public override PlayerState PlayerState => PlayerState.Jump;
        
        public override void Initialize(StateMachine newStateMachine) {
            base.Initialize(newStateMachine);
            _movementTicker = stateMachine.gameObject.GetComponent<MovementTicker>();
        }
        
        public override State Tick() {
            jump.Phase = Input.Phase;
            return base.Tick();
        }

        public override State Exit() {
            jump.Phase = Phase.End;
            return base.Exit();
        }
        
        public override void Transition() {
            base.Transition();
            if ( _movementTicker.Value.y <= 0 && !Controller.isGrounded) {
                stateMachine.SetState<FallState>();
            }
        }
    }
}