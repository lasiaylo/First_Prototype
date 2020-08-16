using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace States {
    public class PoolStateMachine {
        private IState _currentState;
        private PlayerController _gameObject;
        private Dictionary<Type, IState> _states;

        public PoolStateMachine(PlayerController gameObject) {
            SetState<PoolIdleState>();
            _gameObject = gameObject;
            _states = new Dictionary<Type, IState>();
        }

        public void SetState<TState>() where TState: IState {
            Debug.Log(typeof(TState));
            IState state = GetState<TState>();
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

        private IState GetState<TState>() where TState: IState {
            Type type = typeof(TState);
            Debug.Log(type);
            if (_states.ContainsKey(type)) {
                return _states[type];
            }
            IState state = (IState) Activator.CreateInstance(type, this);
            _states.Add(type, state);
            return state;
        }
    }
}