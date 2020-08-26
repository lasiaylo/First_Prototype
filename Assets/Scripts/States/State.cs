using System.Runtime.Remoting.Services;
using UnityEditorInternal;
using UnityEngine;

namespace States {
    public abstract class State: MonoBehaviour {
        public StateMachine StateMachine { get; set; }

        public abstract void Enter();
        
        public abstract void Tick();
        
        public abstract void Exit();
    }

    // Might be useless
    public abstract class PhysicsState: State {
        protected PhysicsState(StateMachine stateMachine) : base() { }
        public abstract void FixedUpdate();
    }
}