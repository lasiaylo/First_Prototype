﻿

using UnityEngine;

namespace States.Player {
    public class RunState: MovableState {
        public RunState(StateMachine<PlayerController> stateMachine) : base(stateMachine) { }
        
        
        public override void Enter(PlayerController owner) {
            Debug.Log("RUNNING");
        }

        public override void Update(PlayerController player) {
            base.Update(player);
            if (player.PlayerInputCache.Direction == Vector3.zero) {
                StateMachine.SetState(new IdleState(StateMachine), player);
            }
        }
    }
}