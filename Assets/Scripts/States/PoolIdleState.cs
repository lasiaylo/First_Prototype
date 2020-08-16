using UnityEngine;

namespace States {
    public class PoolIdleState: IState {
        private PoolStateMachine _sm;    
        
        public PoolIdleState(PoolStateMachine sm) {
            _sm = sm;
        }
        
        
        public void Enter() { }

        public void Update() {
            _sm.SetState<PoolRunningState>();
        }

        public void FixedUpdate() { }

        public void Exit() {
        }
    }

    public class PoolRunningState : IState {
        private PoolStateMachine _sm;    
        
        public PoolRunningState(PoolStateMachine sm) {
            _sm = sm;
        }

        public PoolRunningState() {
            throw new System.NotImplementedException();
        }

        public void Enter() { }

        public void Update() {
            _sm.SetState<PoolIdleState>();
        }

        public void FixedUpdate() { }

        public void Exit() {
        }
        
    }
}