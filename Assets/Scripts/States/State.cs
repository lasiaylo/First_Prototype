using UnityEngine;

namespace States {
    public abstract class State : ScriptableObject {
        public Phase phase;
        [HideInInspector] public StateMachine stateMachine;

        public virtual void Transition() {
            throw new System.NotImplementedException();
        }
    }
}