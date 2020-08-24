using System;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu]
    public class GravityTraits : ScriptableObject, ISerializationCallbackReceiver {
        private float _initGravity;
        private float _initGroundGravity;
        private bool _initIsGrounded;
        private float _initMaxFallSpeed;
        [NonSerialized] public float Gravity;
        [NonSerialized] public float GroundGravity;        
        [NonSerialized] public bool IsGrounded;
        [NonSerialized] public float MaxFallSpeed;

        public void OnAfterDeserialize()
        {
            Gravity = _initGravity;
            GroundGravity = _initGroundGravity;
            IsGrounded = _initIsGrounded;
            MaxFallSpeed = _initMaxFallSpeed;
        }

        public void OnBeforeSerialize() { }
    }
}