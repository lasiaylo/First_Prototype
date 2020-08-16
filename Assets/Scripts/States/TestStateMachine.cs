using System;
using System.Collections.Generic;
using UnityEngine;

namespace States {
    public class TestStateMachine {
        private IState _currentState;
        private GameObject _gameObject;
        private Dictionary<Type, IState> _states;

        public TestStateMachine(GameObject gameObject, IState initialState) {
            _currentState = initialState;
            _gameObject = gameObject;
        }

        public void SetState(IState state)  {
            _currentState.Exit();
            _currentState = state;
            _currentState.Enter();
        }

        public void Update() {
            _currentState.Update();
        }

        public void FixedUpdate() {
            _currentState.FixedUpdate();
        }
    }
}