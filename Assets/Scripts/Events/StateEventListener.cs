using States;
using States.Player;
using UnityEngine;

namespace Events {
    public class StateEventListener : GameEventListener<State> {
        [ContextMenu("Raise Events (Null)")]
        public void RaiseNull() {
            response.Invoke(null);
        }

        [ContextMenu("RaiseEvents (Current State)")]
        public void RaiseState() {
            StateMachine stateMachine = GetComponent<StateMachine>();
            response.Invoke(stateMachine.states[0]);
        }
    }
}