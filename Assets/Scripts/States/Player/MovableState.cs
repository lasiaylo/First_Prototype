using Motion;
using ScriptableObjects;
using ScriptableObjects.Prototypes;
using UnityEngine;

namespace States.Player {
    public abstract class MovableState : State<PlayerController> {
        private LinearAccelerateTraits _traits;
        private GravityTraits _gravity;

        protected MovableState(StateMachine<PlayerController> stateMachine) : base(stateMachine) { }
        
        public override void Tick(PlayerController player) {
            _gravity.IsGrounded = player.Controller.isGrounded;
            _traits.Target = player.PlayerInputCache.Direction;
        }

        public override void Exit(PlayerController player) { }
    }
}