using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Motion;
using ScriptableObjects;
using ScriptableObjects.Prototypes;
using UnityEngine;

namespace States.Player {
    public class JumpState: MovableState {
        public JumpTraits jump;
        public JumpState(StateMachine stateMachine) : base() { }
        public override void Enter() { 
            Debug.Log("JUMPING");
        }

        public override void Tick() {
            base.Tick();
            jump.Action = Input.Action;
        }
    }
}