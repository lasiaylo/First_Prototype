using System;
using System.Collections.Generic;
using States.Player;
using UnityEngine;
using Util.Attributes;

namespace States {
    public class StateMachine: MonoBehaviour {
        public State currentState;
        private bool _stateAlreadySet;
        private Dictionary<Type, State> _states;

        public void Awake() {
            _states = new Dictionary<Type, State>();
            currentState.StateMachine = this;
        }

        public void SetState<T>() where T: State {
            if (_stateAlreadySet) return;
            T state = GetState<T>();
            currentState?.Exit();
            currentState = state;
            currentState.Enter();
            _stateAlreadySet = true;
        }

        public void Tick() {
            _stateAlreadySet = false;
            currentState.Transition();
            currentState.Tick();
        }

        private T GetState<T>() where T : State {
            Type type = typeof(T);
            if (_states.ContainsKey(type)) {
                return (T) _states[type];
            }
            T state = GetComponent<T>();
            state.StateMachine = this;
            _states.Add(type, state);
            return state;
        }
    }
}