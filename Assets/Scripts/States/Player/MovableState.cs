namespace States.Player {
    public abstract class MovableState : State<PlayerController> {
        protected MovableState(PlayerStateMachine stateMachine) : base(stateMachine) { }

        public override void Enter(PlayerController playerController) { }

        public override void Update(PlayerController player) {
            player.PlayerActions
        }
        
        public override void FixedUpdate(PlayerController player) {
            throw new System.NotImplementedException();
        }

        public override void Exit(PlayerController player) {
            throw new System.NotImplementedException();
        }
    }
}