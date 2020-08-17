using UnityEngine;
using UnityEngine.InputSystem;

namespace States {
    public abstract class MovableState : State<PlayerController> {

        protected MovableState(StateMachine<PlayerController> stateMachine) : base(stateMachine) { }

        public override void Enter(PlayerController player) { }

        public override void Update(PlayerController player) {
            StateMachine.Actions;
        }

        public override void FixedUpdate(PlayerController player) {
            throw new System.NotImplementedException();
        }

        public override void Exit(PlayerController player) {
            throw new System.NotImplementedException();
        }
    }
}