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
        [SerializeField] private Vector3 _MaxSpeed;
        
        private Vector3 _runtimeTarget;
        private Vector3 _runtimeMaxSpeed;
        [NonSerialized] public float Acceleration;
        [NonSerialized] public float Deceleration;

        public Vector3 Target {
            get => _runtimeTarget;
            set => _runtimeTarget = Vector3.Scale(value.normalized, _runtimeMaxSpeed);
        }
        
        public Vector3 MaxSpeed {
            get => _runtimeMaxSpeed;
            set {
                _runtimeMaxSpeed = value;
                Target = Target;
            }
        }
        
        public void OnAfterDeserialize() {
            Target = _Target;
            Acceleration = _Acceleration;
            Deceleration = _Deceleration;
            MaxSpeed = _MaxSpeed;
        }

        public void OnBeforeSerialize() {}
    }
}