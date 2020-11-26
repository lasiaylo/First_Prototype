using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Events;
using JetBrains.Annotations;
using Util.Attributes;

namespace States {
    public class StateMachine : Ticker {
        [Expandable] public State currentState;
        public GameEvent<State> stateEvent;
        public List<State> states;
        private bool _stateAlreadySet;
        private Dictionary<Type, State> _stateDict;

        public void Start() {
            _stateDict = new Dictionary<Type, State>();
            for (int i = 0; i < states.Count; i++) {
                states[i] = Instantiate(states[i]);
                InitializeState(states[i]);
            }
            currentState = states[0];
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

        public void InvokeState() {
            currentState.Invoke();
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
            Type type = state.GetType();
            state.Initialize(this); 
           _stateDict.Add(type, state);
        }
    }
}