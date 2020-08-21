
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace States.Player {
    public class JumpState: MovableState {
        public JumpState(StateMachine<PlayerController> stateMachine) : base(stateMachine) { }
        public override void Enter(PlayerController owner) { 
            //Trigger jumping animation
            Debug.Log("JUMPING");
         
        }

        public override void Tick(PlayerController player) {
            base.Tick(player);
        }
    }
}