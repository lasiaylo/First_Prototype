using ScriptableObjects.Prototypes.Trait;

namespace States.Player {
public class JumpState : AirState {
    public JumpTraits jump;

    public override void Enter() {
        base.Enter();
        jump.Phase = Phase.Start;
    }

    public override void Transition() {
        base.Transition();
        if (jump.timer.IsEnd() || Movement.Value.y <= 0) StateMachine.SetState<FallState>();
    }

    public override void Tick() {
        base.Tick();
        jump.Phase = Input.Phase;
    }

    public override void Exit() {
        base.Tick();
        jump.Phase = Phase.End;
    }
}
}