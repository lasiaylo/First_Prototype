using System;
using System.Collections;
using System.Collections.Generic;
using States;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour {
    private PlayerStateMachine _stateMachine;
    
    void Awake() {
        _stateMachine = new PlayerStateMachine(this);
    }

    // Update is called once per frame
    private void FixedUpdate() {
        _stateMachine.FixedUpdate(this);
    }

    public void Update() {
        _stateMachine.Update(this);
    }
}
