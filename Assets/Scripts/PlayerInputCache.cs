using System;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.InputSystem;

public enum Action {
    Jumping,
    NotJumping,
}
public class PlayerInputCache: MonoBehaviour, PlayerInput.IGameplayActions {
    public Action Action { get; private set; }

    public Vector3 Direction { private set; get; }

    [SerializeField] private InputAction.CallbackContext _context;
    
    private PlayerInput _playerInput;

    public void Awake() {
        Direction = new Vector3();
        Action = Action.NotJumping;
        _playerInput = new PlayerInput();
        _playerInput.Gameplay.SetCallbacks(this);
    }
    
    public void OnMovement(InputAction.CallbackContext context) {
        var input = context.ReadValue<Vector2>();
        _context = context;
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