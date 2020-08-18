using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.InputSystem;

public enum Action {
    Jumping,
    NotJumping,
}
public class PlayerAction: MonoBehaviour, PlayerInput.IPlayerActions {
    [SerializeField] private PlayerInput playerInput;

    public Vector3 Direction { get; private set; }

    public Action Action { get; private set; }

    public void Awake() {
        Direction = new Vector3();
        Action = Action.NotJumping;
        playerInput.Player.SetCallbacks(this);
    }
    public void OnMovement(InputAction.CallbackContext context) { 
        var input = context.ReadValue<Vector2>();
        Direction.Set(input.x, 0f, input.y);
        Direction.Normalize();
    }

    public void OnJump(InputAction.CallbackContext context) {
        Action = context.performed ? Action.Jumping : Action.NotJumping;
    }

}