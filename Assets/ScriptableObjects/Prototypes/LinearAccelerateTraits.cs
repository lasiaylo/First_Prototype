using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScriptableObjects.Prototypes
{
    [CreateAssetMenu]
    public class LinearAccelerateTraits : DefaultScriptableObject {
        [SerializeField] private float acceleration;
        [SerializeField] private float deceleration;
        [SerializeField] private Vector3 maxSpeed;

        [NonSerialized] public float Acceleration;
        [NonSerialized] public float Deceleration;
        [NonSerialized] public Vector3 MaxSpeed;
        
        public override void OnAfterDeserialize() {
            Acceleration = acceleration;
            Deceleration = deceleration;
            MaxSpeed = maxSpeed;
        }
    }
}