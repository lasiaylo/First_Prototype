using UnityEngine;

namespace Motion {
    /// <summary>
    /// Adapted from Daniel Fineberg's Jump Implementation:
    /// https://www.gamasutra.com/blogs/DanielFineberg/20150825/244650/Designing_a_Jump_in_Unity.php
    /// </summary>
    public class Jump: MovementMod {
        
        private float _jumpVelocity;
        private float _timer;
        private float _jumpTime;

        public void StartJump(float jumpVelocity, float jumpTime) {
            _jumpVelocity = jumpVelocity;
            _timer = 0;
            _jumpTime = jumpTime;
            Direction = Vector3.up * _jumpVelocity;
        }

        public bool ContinueJump() {
            float propertionCompleted = _timer / _jumpTime;
            Direction = Vector3.Lerp(Direction, Vector3.zero, propertionCompleted);
            _timer += Time.deltaTime;
            return propertionCompleted < 1;
        }
    }
}