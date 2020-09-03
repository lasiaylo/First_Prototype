using JetBrains.Annotations;
using ScriptableObjects.Prototypes.Trait;
using Translate.Movement;

namespace States.Player {
public class JumpState : AirState {
    [NotNull] public JumpTraits jump;
    private Movement _movement;

    public override void Awake() {
        base.Awake();
        _movement = GetComponent<Movement>();
    }

    public override void Enter() {
        base.Enter();
        jump.Phase = Phase.Start;
    }

    public override void Transition() {
        base.Transition();
        if (jump.timer.IsEnd() || _movement.Value.y <= 0) StateMachine.SetState<FallState>();
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