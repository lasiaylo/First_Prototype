using System.Net.NetworkInformation;

namespace States {
    public class PlayerStateMachine: StateMachine<PlayerController> {
        public PlayerStateMachine(PlayerController player) {
            base.SetState(new IdlePlayerState(this), player);
        }
    }
}