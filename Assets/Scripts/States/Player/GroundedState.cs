using ScriptableObjects.Prototypes.Event;

namespace States.Player {
public abstract class GroundedState : MovableState{
    public override void Transition() {
        if (Input.Phase == Phase.Continue)
            StateMachineTicker.SetState<JumpState>();
        else if (!Controller.isGrounded) StateMachineTicker.SetState<FallState>();
    }
}
}