using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Motion;
using ScriptableObjects;
using ScriptableObjects.Prototypes;
using UnityEngine;

namespace States.Player {
    public class JumpState: MovableState {
        private JumpTraits traits = Resources.Load<JumpTraits>("ScriptableObjects/PlayerJump");
        public JumpState(StateMachine<PlayerController> stateMachine) : base(stateMachine) { }
        public override void Enter(PlayerController owner) { 
            Debug.Log("JUMPING");
            traits.Action = owner.PlayerInputCache.Action;
        }

        public override void Tick(PlayerController player) {
            base.Tick(player);
            traits.Action = player.PlayerInputCache.Action;
        }
    }
}