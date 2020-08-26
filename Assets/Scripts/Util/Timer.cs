using System;
using UnityEngine;

namespace Util {
// https://github.com/DapperDino/Dapper-Tools/blob/master/Runtime/Components/Timers/Timer.cs
    public class Timer {
        public float Duration { get; set; }
        public float Remaining { get; private set; }
        

        public Timer(float duration) => Duration = Remaining = duration;

        // public event Action OnTimerEnd;

        public void Tick(float deltaTime) {
            if (IsDone()) { return; }
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

        public Boolean IsDone() {
            return Remaining <= 0f;
        }

        private void CheckForTimerEnd() {
            if (Remaining > 0f) { return; }
            Remaining = 0f;
            // OnTimerEnd?.Invoke();
        }
    }
}