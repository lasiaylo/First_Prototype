using System;
using System.Collections.Generic;
using UnityEngine;
using Events;
using Util.Attributes;

namespace States {
    public class StateMachine : Ticker {
        public State currentState;
        public GameEvent<State> gameEvent;
        private bool _stateAlreadySet;
        private Dictionary<Type, State> _states;

        public void Awake() {
            _states = new Dictionary<Type, State>();
            currentState = ScriptableObject.Instantiate(currentState);
            currentState.stateMachine = this;
            _states.Add(currentState.GetType(), currentState);
        }
        
        public void SetState<TState>() where TState : State {
            if (_stateAlreadySet) return;
            RaiseEvent(Phase.End);
            currentState = GetState<TState>();
            RaiseEvent(Phase.Start); 
            _stateAlreadySet = true;
        }

        public override void Tick() {
            _stateAlreadySet = false;
            RaiseEvent(Phase.Continue);
            currentState.Transition();
        }

        private TState GetState<TState>() where TState : State {
            Type type = typeof(TState);
            if (_states.ContainsKey(type))
                return (TState) _states[type];
            TState state = ScriptableObject.CreateInstance<TState>();
            state.stateMachine = this;
            _states.Add(type, state);
            return state;
        }

        private void RaiseEvent(Phase phase) {
            currentState.phase = phase;
            gameEvent?.Raise(currentState);
        }
    }
}