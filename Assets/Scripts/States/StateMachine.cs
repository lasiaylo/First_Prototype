using System;
using System.Collections.Generic;
using UnityEngine;

namespace States {
    public class StateMachine<T> {
        private State<T> _currentState;
        
        public void SetState(State<T> state, T owner)  {
            _currentState?.Exit(owner);
            _currentState = state;
            _currentState.Enter(owner);
        }

        public void Tick(T owner) {
            _currentState.Tick(owner);
        }
    }
}