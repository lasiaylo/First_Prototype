using States;
using Translate.Movement;
using Translate.Rotation;
using UnityEngine;

[RequireComponent(typeof(StateMachine))]
[RequireComponent(typeof(Movement))]
public class PlayerController : MonoBehaviour {
    private Movement _movement;
    private Rotation _rotation;
    private StateMachine _stateMachine;

    private void Awake() {
        _stateMachine = GetComponent<StateMachine>();
        _movement = GetComponent<Movement>();
        _rotation = GetComponent<Rotation>();
    }

    public void Update() {
        _stateMachine.Tick();
        _movement.Tick();
        _rotation.Tick();
    }
}