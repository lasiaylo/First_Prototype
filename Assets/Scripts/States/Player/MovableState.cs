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

        public override void Transition() {
            if (Controller is null) 
                Controller = stateMachine.gameObject.GetComponent<CharacterController>();
            if (Input is null)
                Input = stateMachine.gameObject.GetComponent<InputManager>();
        }
    }
}