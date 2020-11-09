using System;
using System.Collections.Generic;
using UnityEngine;
using Events;
using JetBrains.Annotations;
using Util.Attributes;

namespace States {
    public class StateMachine : Ticker {
        [Expandable, NotNull] public State currentState;
        public GameEvent<State> stateEvent;
        private bool _stateAlreadySet;
        private Dictionary<Type, State> _states;

        public void Awake() {
            _states = new Dictionary<Type, State>();
            currentState = Instantiate(currentState);
            currentState.Initialize(this);
            _states.Add(currentState.GetType(), currentState);
            stateEvent?.Raise(currentState.Enter());
        }

        public void SetState<TState>() where TState : State {
            if (_stateAlreadySet) return;
            stateEvent?.Raise(currentState.Exit());
            currentState = GetState<TState>();
            stateEvent?.Raise(currentState.Enter());
            _stateAlreadySet = true;
        }

        public override void Tick() {
            _stateAlreadySet = false;
            stateEvent?.Raise(currentState.Tick());
            currentState.Transition();
        }

        private TState GetState<TState>() where TState : State {
            Type type = typeof(TState);
            if (_states.ContainsKey(type))
                return (TState) _states[type];
            TState state = ScriptableObject.CreateInstance<TState>();
            state.Initialize(this);
            _states.Add(type, state);
            return state;
        }
    }
}