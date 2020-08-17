using States;
using UnityEngine;

[RequireComponent(typeof(PlayerActions))] 
public class PlayerController : MonoBehaviour {
    private PlayerStateMachine _stateMachine;
    public float speed;
    public Vector3 velocity;
    
    void Awake() {
        _stateMachine = new PlayerStateMachine(this);
    }

    // Update is called once per frame
    public void FixedUpdate() {
        _stateMachine.FixedUpdate(this);
    }

    public void Update() {
        _stateMachine.Update(this);
    }
}
