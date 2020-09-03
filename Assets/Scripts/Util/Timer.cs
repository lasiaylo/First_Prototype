using System;

namespace Util {
// https://github.com/DapperDino/Dapper-Tools/blob/master/Runtime/Components/Timers/Timer.cs
[Serializable]
public class Timer {
    public float duration;
    public float remaining;

    public Timer(float duration) {
        this.duration = remaining = duration;
    }

    // public event Action OnTimerEnd;

    public void Tick(float deltaTime) {
        if (IsEnd()) return;
        remaining -= deltaTime;
        CheckForTimerEnd();
    }

    public void Reset() {
        remaining = duration;
    }

    public void End() {
        remaining = 0f;
        // Invoke   
    }

    public bool IsEnd() {
        return remaining <= 0f;
    }

    private void CheckForTimerEnd() {
        if (remaining > 0f) return;
        remaining = 0f;
        // OnTimerEnd?.Invoke();
    }
}
}