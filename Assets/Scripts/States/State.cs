using System.Runtime.Remoting.Services;
using UnityEditorInternal;
using UnityEngine;

namespace States {
    public abstract class State<T> {
        protected StateMachine<T> StateMachine { get; private set; }
        protected State(StateMachine<T> stateMachine) {
            StateMachine = stateMachine;
        }
        
        public abstract void Enter(T owner);
        
        public abstract void Update(T owner);
        
        public abstract void Exit(T owner);
    }

    // Might be useless
    public abstract class PhysicsState<T>: State<T> {
        protected PhysicsState(StateMachine<T> stateMachine) : base(stateMachine) { }
        public abstract void FixedUpdate(T owner);
    }
}