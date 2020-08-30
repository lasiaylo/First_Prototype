using System;
using System.Collections.Generic;
using UnityEngine;

namespace States {
public class StateMachine : MonoBehaviour {
    private bool _stateAlreadySet;
    private Dictionary<Type, State> _states;
    public State currentState;

    public void Awake() {
        _states = new Dictionary<Type, State>();
        currentState.StateMachine = this;
    }

    public void SetState<T>() where T : State {
        if (_stateAlreadySet) return;
        var state = GetState<T>();
        currentState?.Exit();
        currentState = state;
        currentState.Enter();
        _stateAlreadySet = true;
    }

    public void Tick() {
        _stateAlreadySet = false;
        currentState.Tick();
        currentState.Transition();
    }

    private T GetState<T>() where T : State {
        var type = typeof(T);
        if (_states.ContainsKey(type)) return (T) _states[type];
        var state = GetComponent<T>();
        state.StateMachine = this;
        _states.Add(type, state);
        return state;
    }
}
}