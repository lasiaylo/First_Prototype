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
    public Action Action { get; private set; }
    public Vector3 Direction;
    private InputAction.CallbackContext context;

    public void Awake() {
        Action = Action.NotJumping;
        Direction = new Vector3();
        _playerInput = new PlayerInput();
        _playerInput.Gameplay.SetCallbacks(this);
    }

    private PlayerInput _playerInput;

    public void OnMovement(InputAction.CallbackContext context) {
        var input = context.ReadValue<Vector2>();
        this.context = context;
        Direction = new Vector3(input.x, 0f, input.y).normalized;
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