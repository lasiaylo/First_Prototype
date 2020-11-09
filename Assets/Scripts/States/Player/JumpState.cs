using JetBrains.Annotations;
using ScriptableObjects.Prototypes.Trait;
using Translate.Movement;
using UnityEngine;

namespace States.Player {
    [CreateAssetMenu(fileName = "JumpState", menuName = "States/JumpState", order = 2)]
    public class JumpState : AirState {
        public JumpTraits jump;
        private MovementTicker _movementTicker;

        public override void Initialize(StateMachine newStateMachine) {
            base.Initialize(newStateMachine);
            _movementTicker = stateMachine.gameObject.GetComponent<MovementTicker>();
        }

        public override State Enter() {
            jump.Phase = Phase.Start;
            return base.Enter();
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
            if (jump.timer.IsEnd() || _movementTicker.Value.y <= 0)
                stateMachine.SetState<FallState>();
        }
    }
}