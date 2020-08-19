using UnityEngine;

namespace States.Player {
    public abstract class MovableState : State<PlayerController> {
        protected MovableState(StateMachine<PlayerController> stateMachine) : base(stateMachine) { }
        
        public override void Update(PlayerController player) {
            player.Movement.Move(player.PlayerInputCache.Direction);
        }
        
        public override void Exit(PlayerController player) { }
    }
}