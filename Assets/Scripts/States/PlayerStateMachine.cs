using System.Net.NetworkInformation;

namespace States {
    public class PlayerStateMachine: StateMachine<PlayerController> {
        public PlayerController Player { get; private set; }
        public PlayerActions Actions { get; private set; }
        
        public PlayerStateMachine(PlayerController player) {
            Player = player;
            Actions = player.GetComponent<PlayerActions>();
            SetState(new IdlePlayerState(this), player);
        }
    }
}