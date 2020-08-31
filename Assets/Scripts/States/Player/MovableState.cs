using ScriptableObjects.Prototypes.Trait;
using ScriptableObjects.Prototypes.Variable;
using ScriptableObjects.Prototypes.Wrapper;
using UnityEngine;
using Util.Attributes;

namespace States.Player {
public abstract class MovableState : State {
    protected CharacterController Controller;
    protected PlayerInputCache Input;
    [Expandable] public LinearAccelerateTraits accelerateTraits;
    [Expandable] public WLinearAccelerateTraits playerMovement;

    public virtual void Awake() {
        Controller = GetComponent<CharacterController>();
        Input = GetComponent<PlayerInputCache>();
    }

    public override void Enter() {
        base.Enter();
        playerMovement.val = accelerateTraits;
    }
}
}