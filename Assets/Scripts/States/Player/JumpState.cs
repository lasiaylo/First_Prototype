using Motion;
using ScriptableObjects.Prototypes;
using UnityEngine;
using Util;

namespace States.Player {
    public class JumpState: AirState {
        public JumpTraits jump;

        public override void Enter() { 
            Debug.Log("JUMPING");
        }

        public override void Tick() {
            base.Tick();
            jump.Action = Input.Action;
        }
    }
}