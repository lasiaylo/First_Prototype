using Translate.Movement;
using Util;

namespace States.Player {
public abstract class AirState : MovableState {
    protected Movement Movement;

    public override void Awake() {
        base.Awake();
        Movement = GetComponent<Movement>();
    }

    public override void Transition() {
        if (!Controller.isGrounded) return;
        if (Movement.Value.GetXz().IsZero())
            StateMachine.SetState<StandState>();
        else
            StateMachine.SetState<RunState>();
    }
}
}