using UnityEngine;

namespace States {
public abstract class State : MonoBehaviour {
    public StateMachine StateMachine { get; set; }

    public abstract void Enter();

    public abstract void Transition();

    public abstract void Tick();

    public abstract void Exit();
}

// Might be useless
public abstract class PhysicsState : State {
    public abstract void FixedUpdate();
}
}