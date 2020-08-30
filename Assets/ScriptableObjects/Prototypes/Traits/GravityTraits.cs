using System;
using UnityEngine;

namespace ScriptableObjects.Prototypes.Traits {
    [CreateAssetMenu(fileName = "GravityTraits", menuName = "Traits/Gravity", order = 0)]
    public class GravityTraits : DefaultScriptableObject {
        [SerializeField] private float gravity;
        [SerializeField] private float groundGravity;
        [SerializeField] private float arcMult;
        [SerializeField] private float arcThreshold;
        [SerializeField] private float maxFallSpeed;

        [NonSerialized] public float Gravity;
        [NonSerialized] public float GroundGravity;
        [NonSerialized] public float ArcMult;
        [NonSerialized] public float ArcThreshold;
        [NonSerialized] public float MaxFallSpeed;

        public override void OnAfterDeserialize() {
            Gravity = gravity;
            GroundGravity = groundGravity;
            ArcMult = arcMult;
            ArcThreshold = arcThreshold;
            MaxFallSpeed = maxFallSpeed;
        }
    }
}