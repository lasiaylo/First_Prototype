using UnityEngine;

namespace States {
    public abstract class State : ScriptableObject {
        public Phase phase;
        [HideInInspector] public StateMachine stateMachine;

        public virtual void Initialize(StateMachine newStateMachine) {
            stateMachine = newStateMachine;
        }

        public virtual State Enter() => ModifyState(Phase.Start);

        public virtual State Tick() => ModifyState(Phase.Continue);

        public virtual State Exit() => ModifyState(Phase.End);

        public virtual void Transition() {
            throw new System.NotImplementedException();
        }

        protected State ModifyState(Phase newPhase) {
            phase = newPhase;
            return this;
        }
    }
}