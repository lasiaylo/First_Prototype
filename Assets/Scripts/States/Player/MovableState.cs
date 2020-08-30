using ScriptableObjects;
using ScriptableObjects.Prototypes;
using ScriptableObjects.Prototypes.Trait;
using ScriptableObjects.Prototypes.Variable;
using ScriptableObjects.Prototypes.Wrapper;
using UnityEngine;
using Util.Attributes;

namespace States.Player {
    public abstract class MovableState : State {
        [Expandable] public WLinearAccelerateTraits playerMovement;
        [Expandable] public LinearAccelerateTraits movement;
        [Expandable] public Vector3Variable input;
        protected CharacterController Controller;
        protected PlayerInputCache Input;

        public virtual void Awake() {
            Controller = GetComponent<CharacterController>();
            Input = GetComponent<PlayerInputCache>();
        }
        
        public override void Enter() {
            playerMovement.val = movement;
        }
        
        public override void Exit() { }
    }
}