namespace States.Player {
    public class IdlePlayerState : MovableState {
        public IdlePlayerState(PlayerStateMachine stateMachine) : base(stateMachine) { }

        public override void Enter(PlayerController owner) {
            // Play Idle Animation   
        }

        public override void Update(PlayerController owner) {
            base.Update(owner);
        }
        
    }
}
    