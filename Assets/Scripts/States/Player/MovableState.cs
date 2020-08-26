using Motion;
using ScriptableObjects;
using ScriptableObjects.Prototypes;
using UnityEngine;

namespace States.Player {
    public abstract class MovableState : State<PlayerController> {
        private LinearAccelerateTraits _traits =
            Resources.Load<LinearAccelerateTraits>("ScriptableObjects/PlayerLinearAccelerate");

        private GravityTraits _gravity = Resources.Load<GravityTraits>("ScriptableObjects/PlayerGravity");

        protected MovableState(StateMachine<PlayerController> stateMachine) : base(stateMachine) { }

        public override void Tick(PlayerController player) {
            Debug.Log(_gravity);
            _gravity.IsGrounded = player.Controller.isGrounded;
            _traits.Target = player.PlayerInputCache.Direction;
        }

        public override void Exit(PlayerController player) { }
    }
}