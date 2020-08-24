using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Motion;
using ScriptableObjects;
using UnityEngine;

namespace States.Player {
    public class JumpState: MovableState {
        public JumpState(StateMachine<PlayerController> stateMachine) : base(stateMachine) { }
        public override void Enter(PlayerController owner) { 
            //Trigger jumping animation
            Debug.Log("JUMPING");
            // owner.Jump.Tick(_jumpVelocity, _jumpTime, owner.PlayerInputCache.Action);
        }

        public override void Tick(PlayerController player) {
            base.Tick(player);
            // player.Jump.Tick(_jumpVelocity, _jumpTime, player.PlayerInputCache.Action);
        }
    }
}