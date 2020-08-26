using Motion;
using ScriptableObjects;
using ScriptableObjects.Prototypes;
using UnityEngine;

namespace States.Player {
    public abstract class MovableState : State {
        public LinearAccelerateTraits linear;
        public GravityTraits gravity;
        protected CharacterController Controller;
        protected PlayerInputCache Input;
        
        public virtual void Awake() {
            Controller = GetComponent<CharacterController>();
            Input = GetComponent<PlayerInputCache>();
        }
        
        public override void Tick() {
            gravity.IsGrounded = Controller.isGrounded;
            linear.Target = Input.Direction;
        }

        public override void Exit() { }
    }
}