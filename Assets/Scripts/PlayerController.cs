using States;
using States.Player;
using UnityEngine;

[RequireComponent(typeof(PlayerAction))]
public class PlayerController : MonoBehaviour {
    public PlayerStateMachine StateMachine { get; private set; }

    public PlayerAction Action { get; private set; }
    public Movement Movement { get; private set; }
    
    
    void Awake() {
        StateMachine = new PlayerStateMachine(this);
        Action = GetComponent<PlayerAction>();
        Movement = GetComponent<Movement>();
    }

    public void Update() {
        StateMachine.Update(this);
    }
}
