using Events;
using States.Player;
using UnityEngine;

namespace States {
public abstract class OldState : MonoBehaviour {
    public StateMachineTicker StateMachineTicker { get; set; }
    [SerializeField] private GameEvent<Phase> gameEvent;

    public virtual void Enter() {
        gameEvent?.Raise(Phase.Start);
    }

    public virtual void Tick() {
        gameEvent?.Raise(Phase.Continue);
    }

    public virtual void Exit() {
        gameEvent?.Raise(Phase.End);
    }

    public abstract void Transition();
}

}