using UnityEngine;

namespace States {
    public class IdlePlayerState : State<PlayerController> {
        public IdlePlayerState(StateMachine stateMachine) : base(stateMachine) { }

        public IdlePlayerState() : base(BASE) {
            throw new System.NotImplementedException();
        }

        public override void Enter(PlayerController owner) {
          
        }

        public override void Update(PlayerController owner) {
            StateMachine.SetState();
        }

        public override void FixedUpdate(PlayerController owner) {
            throw new System.NotImplementedException();
        }

        public override void Exit(PlayerController owner) {
            throw new System.NotImplementedException();
        }
    }
    