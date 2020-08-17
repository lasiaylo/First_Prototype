using UnityEngine;

namespace States {
    public class IdlePlayerState : State<PlayerController> {
        public IdlePlayerState(StateMachine<PlayerController> stateMachine) : base(stateMachine) { }

        public override void Enter(PlayerController owner) {
            throw new System.NotImplementedException();
        }

        public override void Update(PlayerController owner) {
            throw new System.NotImplementedException();
        }

        public override void FixedUpdate(PlayerController owner) {
            throw new System.NotImplementedException();
        }

        public override void Exit(PlayerController owner) {
            throw new System.NotImplementedException();
        }
    }
    