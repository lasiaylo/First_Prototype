using System.Runtime.Remoting.Services;
using UnityEditorInternal;
using UnityEngine;

namespace States {
    public abstract class State<T> {
        protected StateMachine<T> StateMachine { get; }
        protected State(StateMachine<T> stateMachine) {
            StateMachine = stateMachine;
        }

        protected State() { }

        public abstract void Enter(T owner);
        
        public abstract void Update(T owner);
        
        public abstract void FixedUpdate(T owner);
        
        public abstract void Exit(T owner);
    }
}