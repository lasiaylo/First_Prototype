using System;
using UnityEngine;

namespace ScriptableObjects.Prototypes
{
    [CreateAssetMenu]
    public class GravityTraits : ScriptableObject, ISerializationCallbackReceiver {
        [SerializeField] private float gravity;
        [SerializeField] private float groundGravity;
        [SerializeField] private float maxFallSpeed;
        [SerializeField] private bool isGrounded;

        [NonSerialized] public float Gravity;
        [NonSerialized] public float GroundGravity;
        [NonSerialized] public float MaxFallSpeed;
        [NonSerialized] public bool IsGrounded;

        public void OnAfterDeserialize()
        {
            Gravity = gravity;
            GroundGravity = groundGravity;
            MaxFallSpeed = maxFallSpeed;
            IsGrounded = isGrounded;
        }

        public void OnBeforeSerialize() { }
    }
}