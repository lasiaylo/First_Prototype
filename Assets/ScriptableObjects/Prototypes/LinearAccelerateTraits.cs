using System;
using UnityEngine;

namespace ScriptableObjects.Prototypes
{
    [CreateAssetMenu]
    public class LinearAccelerateTraits : ScriptableObject, ISerializationCallbackReceiver
    {
        [SerializeField] private Vector3 _Target;
        [SerializeField] private float _Acceleration;
        [SerializeField] private float _Deceleration;
        [SerializeField] private float _MaxSpeed;
        
        private Vector3 _runtimeValue;
        public Vector3 Target {
            get => _runtimeValue;
            set => _runtimeValue = value.normalized;
        }
        
        [NonSerialized] public float Acceleration;
        [NonSerialized] public float Deceleration;
        [NonSerialized] public float MaxSpeed;

        public void OnAfterDeserialize()
        {
            Target = _Target;
            Acceleration = _Acceleration;
            Deceleration = _Deceleration;
            MaxSpeed = _MaxSpeed;
        }

        public void OnBeforeSerialize() {}
    }
}