using System;
using System.Collections.Generic;
using UnityEngine;

namespace States {
    public abstract class StateMachine<T> {
        private State<T> _currentState;
        
        public void SetState(State<T> state, T owner)  {
            _currentState?.Exit(owner);
            _currentState = state;
            _currentState.Enter(owner);
        }

        public void UpdateState(T owner) {
            _currentState.Update(owner);
        }

        public void FixedUpdate(T owner) {
            _currentState.FixedUpdate(owner);
        }


    }
}