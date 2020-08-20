using UnityEngine;

namespace States.Player {
    public class IdleState : MovableState {
        public IdleState(StateMachine<PlayerController> stateMachine) : base(stateMachine) { }

        public override void Enter(PlayerController owner) {
            // Play Idle Animation   
            Debug.Log("IDLE");
        }

        public override void Tick(PlayerController player) {
            base.Tick(player);
            if (player.PlayerInputCache.Direction != Vector3.zero) {
                StateMachine.SetState(new RunState(StateMachine), player);
            }
        }
    }
}
    