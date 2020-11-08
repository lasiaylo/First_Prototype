namespace States.Player {
public abstract class GroundedOldState : MovableOldState{
    public override void Transition() {
        if (Input.Phase == Phase.Continue)
            StateMachineTicker.SetState<JumpOldState>();
        else if (!Controller.isGrounded) StateMachineTicker.SetState<FallOldState>();
    }
}
}