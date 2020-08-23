using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Motion;
using UnityEngine;

namespace States.Player {
    public class JumpState: MovableState {
        private float _jumpVelocity = 10;
        private float _jumpTime = 10;
        public JumpState(StateMachine<PlayerController> stateMachine) : base(stateMachine) { }
        public override void Enter(PlayerController owner) { 
            //Trigger jumping animation
            Debug.Log("JUMPING");
            owner.Jump.StartJump(_jumpVelocity, _jumpTime, owner.PlayerInputCache.Action);
        }

        public override void Tick(PlayerController player) {
            base.Tick(player);
            if (player.Jump.Tick(player.PlayerInputCache.Action) == Action.NotJumping) {
                StateMachine.SetState(new RunState(StateMachine), player);
            }
        }
    }
}