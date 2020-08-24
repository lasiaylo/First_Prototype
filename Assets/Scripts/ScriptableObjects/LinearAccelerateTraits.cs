using System;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu]
    public class LinearAccelerateTraits : ScriptableObject, ISerializationCallbackReceiver
    {
        private Vector3 _initTarget;
        private float _initAcceleration;
        private float _initDeceleration;
        private float _initMaxSpeed;
        private Vector3 _Target;
        public Vector3 Target {
            get => _Target;
            set => _Target = value.normalized;
        }
        
        [NonSerialized] public float Acceleration;
        [NonSerialized] public float Deceleration;
        [NonSerialized] public float MaxSpeed;

        public void OnAfterDeserialize()
        {
            _Target = _initTarget;
            Acceleration = _initAcceleration;
            Deceleration = _initDeceleration;
            MaxSpeed = _initMaxSpeed;
        }

        public void OnBeforeSerialize() {}
    }
}