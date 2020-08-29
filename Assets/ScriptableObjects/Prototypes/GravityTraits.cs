using System;
using UnityEngine;

namespace ScriptableObjects.Prototypes
{
    [CreateAssetMenu]
    public class GravityTraits : ScriptableObject, ISerializationCallbackReceiver {
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

        public void OnAfterDeserialize()
        {
            Gravity = gravity;
            GroundGravity = groundGravity;
            ArcMult = arcMult;
            ArcThreshold = arcThreshold;
            MaxFallSpeed = maxFallSpeed;
            IsGrounded = isGrounded;
        }

        [NonSerialized] public bool IsGrounded;

        public void OnBeforeSerialize() { }
    }
}