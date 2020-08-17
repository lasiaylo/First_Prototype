using System.Runtime.Remoting.Services;
using UnityEditorInternal;
using UnityEngine;

namespace States {
    public abstract class State<TOwner> where TOwner : IStateful<TOwner> {
        protected readonly StateMachine<TOwner> StateMachine;

        protected State(TOwner owner) {
            StateMachine = owner.StateMachine;
        }

        public abstract void Enter(TOwner owner);
        
        public abstract void Update(TOwner owner);
        
        public abstract void FixedUpdate(TOwner owner);
        
        public abstract void Exit(TOwner owner);
    }
}