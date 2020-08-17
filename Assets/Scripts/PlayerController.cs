using System;
using System.Collections;
using System.Collections.Generic;
using States;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;




public class PlayerController : MonoBehaviour {
    private State<PlayerController> _currentState;
    
    void Awake() {
        
    }

    // Update is called once per frame
    private void FixedUpdate() {
        _currentState.FixedUpdate();
    }

    public void Update() {
        
        _currentState.Update(); 
    }

    public void SetState(State<PlayerController> state)  {
        _currentState?.Exit();
        _currentState = state;
        _currentState.Enter();
    }
}
