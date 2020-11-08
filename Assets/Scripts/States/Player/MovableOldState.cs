using JetBrains.Annotations;
using ScriptableObjects.Prototypes.Trait;
using ScriptableObjects.Prototypes.Variable;
using ScriptableObjects.Prototypes.Wrapper;
using UnityEngine;
using Util.Attributes;

namespace States.Player {
public abstract class MovableOldState : OldState {
    protected CharacterController Controller;
    protected InputManager Input;
    [Expandable, NotNull] public LinearAccelerateTraits accelerateTraits;
    [Expandable, NotNull] public WLinearAccelerateTraits traits;

    public virtual void Awake() {
        Controller = GetComponent<CharacterController>();
        Input = GetComponent<InputManager>();
    }

    public override void Enter() {
        base.Enter();
        traits.val = accelerateTraits;
    }
}
}