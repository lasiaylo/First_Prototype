using ScriptableObjects;
using ScriptableObjects.Prototypes;
using ScriptableObjects.Prototypes.Traits;
using UnityEngine;
using Util.Attributes;

namespace States.Player {
    public abstract class MovableState : State {
        [Expandable] public WLinearAccelerateTraits playerMovement;
        [Expandable] public LinearAccelerateTraits movement;
        protected CharacterController Controller;
        protected PlayerInputCache Input;

        public virtual void Awake() {
            Controller = GetComponent<CharacterController>();
            Input = GetComponent<PlayerInputCache>();
        }
        
        public override void Enter() {
            Debug.Log(movement);
            playerMovement.obj = movement;
        }
        
        public override void Exit() { }
    }
}