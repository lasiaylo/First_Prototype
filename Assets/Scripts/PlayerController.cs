using Motion;
using States;
using States.Player;
using UnityEngine;
using Util;

[RequireComponent(typeof(Motion.Movement))]
[RequireComponent(typeof(PlayerInputCache))]
public class PlayerController : MonoBehaviour {
    public CharacterController Controller { get; private set; }
    public Gravity Gravity { get; private set; } 
    public Movement Movement { get; private set; }
    public PlayerInputCache PlayerInputCache { get; private set; }
    public LinearMove LinearMove { get; private set; }
    public PlayerStateMachine StateMachine { get; private set; }

    void Awake() {
        Controller = GetComponent<CharacterController>();
        Gravity = GetComponent<Gravity>();
        LinearMove = GetComponent<LinearMove>();
        PlayerInputCache = GetComponent<PlayerInputCache>();
        StateMachine = new PlayerStateMachine(this);

        Movement = GetComponent<Motion.Movement>();
        Movement.AddModifier(Gravity);
        Movement.AddModifier(LinearMove);

    }

    public void Update() {
        StateMachine.Tick(this);
        Movement.Tick();
    }
}
