using System;
using System.Collections.Generic;
using UnityEngine;

namespace States {
    public class StateMachine<T> {
        private State<T> _currentState;
        private bool _stateAlreadySet;
        
        public void SetState(State<T> state, T owner)  {
            _currentState?.Exit(owner);
            _currentState = state;
            _currentState.Enter(owner);
            _stateAlreadySet = true;
        }

        public void Tick(T owner) {
            _stateAlreadySet = false;
            _currentState.Tick(owner);
        }
    }
}