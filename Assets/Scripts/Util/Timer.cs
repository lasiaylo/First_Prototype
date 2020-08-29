using System;
using UnityEngine;

namespace Util {
// https://github.com/DapperDino/Dapper-Tools/blob/master/Runtime/Components/Timers/Timer.cs
    [Serializable]
    public class Timer {
        public float Duration;
        public float Remaining;

        public Timer(float duration) => Duration = Remaining = duration;

        // public event Action OnTimerEnd;

        public void Tick(float deltaTime) {
            if (IsEnd()) { return; }
            Remaining -= deltaTime;
            CheckForTimerEnd();
        }

        public void Reset() {
            Remaining = Duration;
        }

        public void End() {
            Remaining = 0f;
         // Invoke   
        }

        public Boolean IsEnd() {
            return Remaining <= 0f;
        }

        private void CheckForTimerEnd() {
            if (Remaining > 0f) { return; }
            Remaining = 0f;
            // OnTimerEnd?.Invoke();
        }
    }
}