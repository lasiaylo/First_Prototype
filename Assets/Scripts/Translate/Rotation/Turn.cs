using ScriptableObjects.Prototypes;
using Translate.Movement;
using UnityEngine;
using Util.Attributes;

namespace Translate.Rotation {
    public class Turn : Mod<Quaternion> {
        [Expandable] public TurnTraits traits; 
        public override Quaternion Modify(Quaternion val) {
            return Quaternion.RotateTowards(
                val, 
                Quaternion.LookRotation(traits.Direction), 
                traits.TurnSpeed * Time.deltaTime
            );
        }
    }
}