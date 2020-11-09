using JetBrains.Annotations;
using ScriptableObjects.Prototypes.Trait;
using ScriptableObjects.Prototypes.Wrapper;
using UnityEngine;
using Util.Attributes;

namespace States.Player {
    public abstract class MovableState : State {
        protected CharacterController Controller;
        protected InputManager Input;
        [Expandable, NotNull] public LinearAccelerateTraits accelerateTraits;
        [Expandable, NotNull] public WLinearAccelerateTraits traits;

        public override void Initialize(StateMachine newStateMachine) {
            base.Initialize(newStateMachine);
            Controller = stateMachine.gameObject.GetComponent<CharacterController>();
            Input = stateMachine.gameObject.GetComponent<InputManager>();
        }
    }
}