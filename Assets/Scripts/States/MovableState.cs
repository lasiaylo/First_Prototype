using UnityEngine;
using UnityEngine.InputSystem;

namespace States {    
    
    public abstract class MovableState: IPlayerState {
        
        public void Enter(PlayerController player) {
            spee = 
        }

        public void Update(PlayerController player) {
            throw new System.NotImplementedException();
        }

        public void FixedUpdate(PlayerController player) {
            throw new System.NotImplementedException();
        }

        public void Exit(PlayerController player) {
            throw new System.NotImplementedException();
        }

}