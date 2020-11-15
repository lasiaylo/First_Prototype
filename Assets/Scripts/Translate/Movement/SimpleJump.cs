using JetBrains.Annotations;
using ScriptableObjects.Prototypes.Trait;
using UnityEngine;
using Util.Attributes;

namespace Translate.Movement {
    public class SimpleJump : Mod<Vector3> {
        [Expandable, NotNull] public JumpTraits traits;

        public void Jump() {
            traits.Phase = Phase.Start;
        }

        public override Vector3 Modify(Vector3 direction) {
            if (traits.Phase == Phase.Start) {
                traits.Phase = Phase.End;
                return new Vector3(direction.x, traits.Speed, direction.z);
            }

            return direction;
        }
    }
}