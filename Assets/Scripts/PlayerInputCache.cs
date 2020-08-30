using System;
using ScriptableObjects.Prototypes;
using UnityEngine;
using UnityEngine.InputSystem;
using Util.Attributes;

[Serializable]
public enum Action: int {
    NotJumping,
    ContinueJump,
    StartJump,
}
public class PlayerInputCache: MonoBehaviour, PlayerInput.IGameplayActions {
    [Expandable] public Vector3Variable direction;
    [SerializeField] private Action action = Action.NotJumping;

    public Action Action {
        get => action;
        private set => action = value;
    }

    public Vector3 Direction {
        get => direction.val;
        private set => direction.val = value.normalized;
    }

    public void Awake() {
        _playerInput = new PlayerInput();
        _playerInput.Gameplay.SetCallbacks(this);
    }

    private PlayerInput _playerInput;

    public void OnMovement(InputAction.CallbackContext context) {
        var input = context.ReadValue<Vector2>();
        Direction = new Vector3(input.x, 0f, input.y);
    }

    public void OnJump(InputAction.CallbackContext context) {
        Action = context.performed
            ? Action.ContinueJump
            : Action.NotJumping;
    }

    public void OnEnable() {
        _playerInput.Enable();
    }

    public void OnDisable() {
        _playerInput.Disable();
    }
}