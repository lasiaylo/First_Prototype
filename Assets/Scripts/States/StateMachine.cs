using System;
using System.Collections.Generic;
using UnityEngine;

namespace States {
    public class StateMachine<T> {
        private State<T> _currentState;
        
        public void SetState(State<T> state)  {
            _currentState?.Exit(owner);
            _currentState = state;
            _currentState.Enter(owner);
        }

        public void Update(T owner) {
            _currentState.Update(owner);
        }

        public void FixedUpdate(T owner) {
            _currentState.FixedUpdate(owner);
        }
    }
}