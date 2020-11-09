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
        public List<State> states;
        private bool _stateAlreadySet;
        private Dictionary<Type, State> _stateDict;

        public void Awake() {
            _stateDict = new Dictionary<Type, State>();
            currentState = Instantiate(currentState);
            foreach (State state in states) {
                InitializeState(state);
            }
            InitializeState(currentState);
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
            if (_stateDict.ContainsKey(type))
                return (TState) _stateDict[type];
            TState state = ScriptableObject.CreateInstance<TState>();
            InitializeState(state);
            return state;
        }

        private void InitializeState(State state) {
            state.Initialize(this);
            _stateDict.Add(state.GetType(), state);
        }
    }
}