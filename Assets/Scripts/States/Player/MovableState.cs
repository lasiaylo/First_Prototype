using JetBrains.Annotations;
using ScriptableObjects.Prototypes.Trait;
using ScriptableObjects.Prototypes.Wrapper;
using UnityEngine;
using Util.Attributes;

public enum PlayerState {
    Idle,
    Run,
    Jump,
    Fall,
}

namespace States.Player {
    public abstract class MovableState : State {
        [Expandable, NotNull] public LinearAccelerateTraits accelerateTraits;
        [Expandable, NotNull] public WLinearAccelerateTraits wrapper;
        protected CharacterController Controller;
        protected InputManager Input;

        public abstract PlayerState PlayerState { get; }

        public override void Initialize(StateMachine newStateMachine) {
            base.Initialize(newStateMachine);
            Controller = stateMachine.gameObject.GetComponent<CharacterController>();
            Input = stateMachine.gameObject.GetComponent<InputManager>();
        }

        public override State Enter() {
            wrapper.Val = accelerateTraits;
            return base.Enter();
        }
    }
}