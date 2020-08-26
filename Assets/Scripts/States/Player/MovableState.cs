using Motion;
using ScriptableObjects;
using ScriptableObjects.Prototypes;
using UnityEngine;

namespace States.Player {
    public abstract class MovableState : State {
        public LinearAccelerateTraits linear;
        public GravityTraits gravity;
        protected PlayerInputCache Input;
        protected CharacterController Controller; 
        
        public void Awake() {
            Input = GetComponent<PlayerInputCache>();
            Debug.Log("PLAYER");
            Debug.Log(Input);
            Controller = GetComponent<CharacterController>();
        }
        
        public override void Tick() {
            gravity.IsGrounded = Controller.isGrounded;
            linear.Target = Input.Direction;
        }

        public override void Exit() { }
    }
}