
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace States.Player {
    public class JumpState: MovableState {
        private float _jumpVelocity = 50;
        private float _jumpTime = 10;
        public JumpState(StateMachine<PlayerController> stateMachine) : base(stateMachine) { }
        public override void Enter(PlayerController owner) { 
            //Trigger jumping animation
            Debug.Log("JUMPING");
            owner.Jump.StartJump(50, 10);
            
         
        }

        public override void Tick(PlayerController player) {
            base.Tick(player);
            player.Jump.ContinueJump();
        }
    }
}