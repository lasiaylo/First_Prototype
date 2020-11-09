using JetBrains.Annotations;
using ScriptableObjects.Prototypes.Trait;
using Translate.Movement;
using UnityEngine;

namespace States.Player {
    [CreateAssetMenu(fileName = "JumpState", menuName = "States/JumpState", order = 2)]

    public class JumpState : MovableState {
        [NotNull] public JumpTraits jump;
        private MovementTicker _movementTicker;

        public override void Transition() {
            base.Transition();
            if (_movementTicker is null)
                _movementTicker = stateMachine.gameObject.GetComponent<MovementTicker>();
            if (jump.timer.IsEnd() || _movementTicker.Value.y <= 0)
                stateMachine.SetState<FallState>();
        }
    }
}