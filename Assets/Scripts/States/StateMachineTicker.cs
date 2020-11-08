using System;
using System.Collections.Generic;
using UnityEngine;

namespace States {
public class StateMachineTicker : Ticker {
    private bool _stateAlreadySet;
    private Dictionary<Type, OldState> _states;
    public OldState currentOldState;

    public void Awake() {
        _states = new Dictionary<Type, OldState>();
        currentOldState.StateMachineTicker = this;
    }

    public void SetState<T>() where T : OldState {
        if (_stateAlreadySet) return;
        T state = GetState<T>();
        currentOldState?.Exit();
        currentOldState = state;
        currentOldState.Enter();
        _stateAlreadySet = true;
    }

    public override void Tick() {
        _stateAlreadySet = false;
        currentOldState.Tick();
        currentOldState.Transition();
    }

    private T GetState<T>() where T : OldState {
        var type = typeof(T);
        if (_states.ContainsKey(type)) return (T) _states[type];
        var state = GetComponent<T>();
        state.StateMachineTicker = this;
        _states.Add(type, state);
        return state;
    }
}
}