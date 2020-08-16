using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace States {
    public class StateMachine {
        private IState _currentState;
        private GameObject _gameObject;
        private Dictionary<Type, IState> _states;

        public StateMachine(GameObject gameObject, IState initialState) {
            _currentState = initialState;
            _gameObject = gameObject;
            _states = new Dictionary<Type, IState>();
        }

        public void SetState<TState>() where TState: IState {
            IState state = GetState<TState>();
            _currentState.Exit(_gameObject);
            _currentState = state;
            _currentState.Enter(_gameObject);
        }

        public void Update() {
            _currentState.Update(_gameObject);
        }

        public void FixedUpdate() {
            _currentState.FixedUpdate(_gameObject);
        }

        private IState GetState<TState>() where TState: IState {
            Type type = typeof(TState);
            if (_states.ContainsKey(type)) {
                return _states[type];
            }
            IState state = (IState) Activator.CreateInstance(type);
            _states.Add(type, state);
            return state;
        }
    }
}