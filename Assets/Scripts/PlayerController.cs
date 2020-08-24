using Motion;
using States.Player;
using UnityEngine;

[RequireComponent(typeof(Motion.Movement))]
[RequireComponent(typeof(PlayerInputCache))]
public class PlayerController : MonoBehaviour {
    public CharacterController Controller { get; private set; }
    public Gravity Gravity { get; private set; }
    
    public Jump Jump { get; private set; }
    public Movement Movement { get; set; }
    public PlayerInputCache PlayerInputCache { get; private set; }
    public PlayerStateMachine StateMachine { get; private set; }
    public LinearAccelerateXz LinearAccelerateXz { get; private set; }
    
    void Awake() {
        Controller = GetComponent<CharacterController>();
        Gravity = GetComponent<Gravity>();
        Jump = GetComponent<Jump>();
        LinearAccelerateXz = GetComponent<LinearAccelerateXz>();
        PlayerInputCache = GetComponent<PlayerInputCache>();
        StateMachine = new PlayerStateMachine(this);

        Movement = GetComponent<Movement>();
        Movement.AddModifier(Gravity);
        Movement.AddModifier(LinearAccelerateXz);
        Movement.AddModifier(Jump);
    }

    public void Update() {
        StateMachine.Tick(this);
        Movement.Tick();
    }
}
