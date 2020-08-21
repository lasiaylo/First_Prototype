

using UnityEngine;
using Util;

namespace States.Player {
    public class RunState: MovableState {
        public RunState(StateMachine<PlayerController> stateMachine) : base(stateMachine) { }
        
        
        public override void Enter(PlayerController owner) {
            Debug.Log("RUNNING");
        }

        public override void Tick(PlayerController player) {
            base.Tick(player);
            if (player.PlayerInputCache.Action == Action.Jumping) {
                StateMachine.SetState(new JumpState(StateMachine), player);
            }
            else if (player.PlayerInputCache.Direction.IsZero() 
                     && player.Movement.Direction.Xz().IsZero()) {
                StateMachine.SetState(new IdleState(StateMachine), player);
            }
        }
    }
}