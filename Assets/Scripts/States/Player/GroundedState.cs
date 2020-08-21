namespace States.Player {
    public class GroundedState: MovableState {
        public GroundedState(StateMachine<PlayerController> stateMachine) : base(stateMachine) { }
        public override void Enter(PlayerController owner) {
            
        }

        public override void Tick(PlayerController player) {
            base.Tick(player);
            if (player.PlayerInputCache.Action == Action.Jumping) {
                StateMachine.SetState(new JumpState(StateMachine), player);
            }
        }
    }
}