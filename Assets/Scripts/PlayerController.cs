using States;
using States.Player;
using UnityEngine;

[RequireComponent(typeof(Movement))]
[RequireComponent(typeof(PlayerInputCache))]
public class PlayerController : MonoBehaviour {
    public PlayerStateMachine StateMachine { get; private set; }

    public PlayerInputCache PlayerInputCache { get; private set; }
    public Movement Movement { get; private set; }
    
    
    void Awake() {
        StateMachine = new PlayerStateMachine(this);
        PlayerInputCache = GetComponent<PlayerInputCache>();
        Movement = GetComponent<Movement>();
    }

    public void Update() {
        StateMachine.Update(this);
    }
}
