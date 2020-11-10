using UnityEngine;

namespace States.Player {
    [CreateAssetMenu(fileName = "FallState", menuName = "States/FallState", order = 4)]

    public class FallState : AirState {
        public override PlayerState PlayerState => PlayerState.Fall;
    }
}