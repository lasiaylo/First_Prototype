using States;
using States.Player;
using UnityEngine;

[RequireComponent(typeof(PlayerActions))] 
public class PlayerController : MonoBehaviour {
    private PlayerStateMachine _stateMachine;
    public float speed;
    public Vector3 velocity;
    public PlayerActions PlayerActions { get; private set; }
    
    void Awake() {
        _stateMachine = new PlayerStateMachine(this);
        PlayerActions = GetComponent<PlayerActions>();
    }

    // Update is called once per frame
    public void FixedUpdate() {
        _stateMachine.FixedUpdate(this);
    }

    public void Update() {
        _stateMachine.Update(this);
    }
}
