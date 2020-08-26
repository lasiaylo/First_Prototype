using System;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

[Serializable]
public enum Action: int {
    NotJumping,
    Jumping,
}
public class PlayerInputCache: MonoBehaviour, PlayerInput.IGameplayActions {
    private InputAction.CallbackContext context;

    [SerializeField] private Action action = Action.NotJumping;
    [SerializeField] private Vector3 direction = Vector3.zero;

    public Action Action {
        get => action;
        private set => action = value;
    }

    public Vector3 Direction {
        get => direction;
        private set => direction = value.normalized;

    }

    public void Awake() {
        _playerInput = new PlayerInput();
        _playerInput.Gameplay.SetCallbacks(this);
    }

    private PlayerInput _playerInput;

    public void OnMovement(InputAction.CallbackContext context) {
        var input = context.ReadValue<Vector2>();
        this.context = context;
        Direction = new Vector3(input.x, 0f, input.y);
    }

    public void OnJump(InputAction.CallbackContext context) {
        Action = context.performed ? Action.Jumping : Action.NotJumping;
    }

    public void OnEnable() {
        _playerInput.Enable();
    }

    public void OnDisable() {
        _playerInput.Disable();
    }
}