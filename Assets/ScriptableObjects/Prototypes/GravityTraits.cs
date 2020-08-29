using System;
using UnityEngine;

namespace ScriptableObjects.Prototypes
{
    [CreateAssetMenu]
    public class GravityTraits : LockedScriptableObject {
        [SerializeField] private float gravity;
        [SerializeField] private float groundGravity;
        [SerializeField] private float arcMult;
        [SerializeField] private float arcThreshold;
        [SerializeField] private float maxFallSpeed;
        [SerializeField] private bool isGrounded;

        [NonSerialized] public float Gravity;
        [NonSerialized] public float GroundGravity;
        [NonSerialized] public float ArcMult;
        [NonSerialized] public float ArcThreshold;
        [NonSerialized] public float MaxFallSpeed;
        [NonSerialized] public bool IsGrounded;

        public override void OnAfterDeserialize() {
            Gravity = gravity;
            GroundGravity = groundGravity;
            ArcMult = arcMult;
            ArcThreshold = arcThreshold;
            MaxFallSpeed = maxFallSpeed;
            IsGrounded = isGrounded;
        }
    }
}