using JetBrains.Annotations;
using UnityEngine;

namespace Events.State_Machine_Behaviour {
    public abstract class GameEventRaiser<T> : StateMachineBehaviour {
        [SerializeField, NotNull] private GameEvent<T> gameEvent;
        public T Value;
        // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
            gameEvent.Raise(Value);
        }
    }
}
