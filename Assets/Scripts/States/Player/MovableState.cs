using UnityEngine;

namespace States.Player {
    public abstract class MovableState : State<PlayerController> {
        private float _acceleration = 1.85f;
        private float _friction = 0.75f; 
        private float _maxSpeed = 10;

        protected MovableState(StateMachine<PlayerController> stateMachine) : base(stateMachine) { }
        
        public override void Tick(PlayerController player) {
            player.Gravity.Tick(player.Controller.isGrounded);
            player.LinearAccelerate.Tick(
                _acceleration,
                _friction,
                _maxSpeed,
                player.PlayerInputCache.Direction);
        }
        
        public override void Exit(PlayerController player) { }
        
    }
}