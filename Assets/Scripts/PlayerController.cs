using System;
using System.Collections;
using System.Collections.Generic;
using States;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour, PlayerInput.IPlayerActions, IStateful<PlayerController>{
    [SerializeField] private PlayerInput playerInput;

    public Vector3 direction;

    public bool jumping;
    private IStateful<PlayerController> _statefulImplementation;

    public StateMachine<PlayerController> StateMachine { get; private set; }
    // Start is called before the first frame update

    void Awake() {
        direction = new Vector3();
        jumping = false;
        StateMachine = new StateMachine<PlayerController>();
        StateMachine.SetState(new IdlePlayerState());
        playerInput.Player.SetCallbacks(this);
    }

    // Update is called once per frame
    void Update() {
        StateMachine.Update(this);    
    }

    private void FixedUpdate() {
        StateMachine.FixedUpdate(this);
    }

    public void OnMovement(InputAction.CallbackContext context) {
        var input = context.ReadValue<Vector2>();
        direction.Set(input.x, 0, input.y);
    }
    

    public void OnJump(InputAction.CallbackContext context) {
        jumping = context.performed;
    }
    
}
