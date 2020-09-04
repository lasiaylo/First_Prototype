﻿using System;
using JetBrains.Annotations;
using ScriptableObjects.Prototypes.Variable;
using UnityEngine;
using UnityEngine.InputSystem;
using Util.Attributes;

[Serializable]
public class InputManager : MonoBehaviour, PlayerInput.IGameplayActions {
    private PlayerInput _playerInput;
    [Expandable, NotNull] public Vector3Variable inputDirection;
    [Expandable, NotNull] public Phase phase = Phase.End;

    public Phase Phase {
        get => phase;
        private set => phase = value;
    }

    public Vector3 InputDirection {
        get => inputDirection.val;
        private set => inputDirection.val = value.normalized;
    }

    public void Awake() {
        _playerInput = new PlayerInput();
        _playerInput.Gameplay.SetCallbacks(this);
    }

    public void OnMovement(InputAction.CallbackContext context) {
        var input = context.ReadValue<Vector2>();
        InputDirection = new Vector3(input.x, 0f, input.y);
    }

    public void OnJump(InputAction.CallbackContext context) {
        Phase = context.started ? Phase.Continue : Phase.End;
    }

    public void OnEnable() {
        _playerInput.Enable();
    }

    public void OnDisable() {
        _playerInput.Disable();
    }
}