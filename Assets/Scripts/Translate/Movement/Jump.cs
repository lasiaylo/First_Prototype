using JetBrains.Annotations;
using ScriptableObjects.Prototypes.Trait;
using UnityEngine;
using Util.Attributes;

namespace Translate.Movement {
/// <summary>
///     Handles Jumping for GameObjects
/// </summary>
/// <remarks>
///     Adapted from Celeste's Jump Implementation:
///     https://github.com/NoelFB/Celeste/blob/master/Source/Player/Player.cs#L2960
/// </remarks>
public class Jump : Mod<Vector3> {
    [Expandable, NotNull] public JumpTraits traits;

    public override Vector3 Modify(Vector3 val) {
        if (traits.Phase == Phase.Start) return StartJump(val);
        if (traits.Phase == Phase.Continue) return ContinueJump(val);
        return EndJump(val);
    }

    private Vector3 StartJump(Vector3 direction) {
        traits.timer.Reset();
        return new Vector3(direction.x, traits.Speed, direction.z);
    }

    private Vector3 ContinueJump(Vector3 direction) {
        traits.timer.Tick(Time.deltaTime);
        float continueVelocity = Mathf.Min(traits.Speed, direction.y);
        return new Vector3(direction.x, continueVelocity, direction.z);
    }

    private Vector3 EndJump(Vector3 direction) {
        traits.timer.End();
        return direction;
        // float reducedVelocity = direction.y > 0
        //     ? direction.y / 2
        //     : direction.y;
        // return new Vector3(direction.x, reducedVelocity, direction.z);
    }
}
}