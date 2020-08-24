using UnityEngine;

namespace States.Player {
    public abstract class MovableState : State<PlayerController> {
        private float _acceleration = 38.85f;
        private float _friction = 7.5f; 
        private float _maxSpeed = 10;

        protected MovableState(StateMachine<PlayerController> stateMachine) : base(stateMachine) { }
        
        public override void Tick(PlayerController player) {
            player.Gravity.Tick(player.Controller.isGrounded);
            player.LinearAccelerateXz.Tick(               
                player.PlayerInputCache.Direction,
                _acceleration,
                _friction,
                _maxSpeed
            );
        }

        public override void Exit(PlayerController player) { }
        
    }
}