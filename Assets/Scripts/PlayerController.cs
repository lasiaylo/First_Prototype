using States;
using States.Player;
using Translate.Movement;
using UnityEngine;
using Util;

[RequireComponent(typeof(StateMachine))]
[RequireComponent(typeof(Movement))]
public class PlayerController : MonoBehaviour {
    private StateMachine _stateMachine;
    private Movement _movement;

    void Awake() {
        _stateMachine = GetComponent<StateMachine>();
        _movement = GetComponent<Movement>();
    }

    public void Update() {
        _stateMachine.Tick();
        _movement.Tick();
    }
}
