using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScriptableObjects.Prototypes
{
    [CreateAssetMenu]
    public class LinearAccelerateTraits : LockedScriptableObject {
        [SerializeField] private Vector3 target;
        [SerializeField] private float acceleration;
        [SerializeField] private float deceleration;
        [SerializeField] private Vector3 maxSpeed;
        
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
        
        public override void OnAfterDeserialize() {
            Target = target;
            Acceleration = acceleration;
            Deceleration = deceleration;
            MaxSpeed = maxSpeed;
        }
    }
}