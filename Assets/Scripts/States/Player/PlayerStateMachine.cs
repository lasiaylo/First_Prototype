namespace States.Player {
    public class PlayerStateMachine: StateMachine<PlayerController> {
        public PlayerController PlayerController { get; private set; }

        
        public PlayerStateMachine(PlayerController playerController) {
            PlayerController = playerController;
            SetState(new IdlePlayerState(this), playerController);
        }
    }
}