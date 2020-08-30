using System;
using ScriptableObjects.Prototypes.Variable;
using UnityEngine;
using UnityEngine.InputSystem;
using Util.Attributes;

[Serializable]
public class PlayerInputCache : MonoBehaviour, PlayerInput.IGameplayActions {
    private PlayerInput _playerInput;
    [Expandable] public Vector3Variable direction;
    [Expandable] public Phase phase;

    public Phase Phase {
        get => phase;
        private set => phase = value;
    }

    public Vector3 Direction {
        get => direction.val;
        private set => direction.val = value.normalized;
    }

    public void OnMovement(InputAction.CallbackContext context) {
        var input = context.ReadValue<Vector2>();
        Direction = new Vector3(input.x, 0f, input.y);
    }

    public void OnJump(InputAction.CallbackContext context) {
        Phase = context.performed
            ? Phase.Continue
            : Phase.End;
    }

    public void Awake() {
        _playerInput = new PlayerInput();
        _playerInput.Gameplay.SetCallbacks(this);
    }

    public void OnEnable() {
        _playerInput.Enable();
    }

    public void OnDisable() {
        _playerInput.Disable();
    }
}