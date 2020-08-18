namespace States.Player {
    public abstract class MovableState : State<PlayerController> {
        protected MovableState(PlayerStateMachine stateMachine) : base(stateMachine) { }

        public override void Enter(PlayerController playerController) { }

        public override void Update(PlayerController player) {
            player.Movement.Move(player.Action.Direction);
        }
        
        public override void Exit(PlayerController player) { }
    }
}