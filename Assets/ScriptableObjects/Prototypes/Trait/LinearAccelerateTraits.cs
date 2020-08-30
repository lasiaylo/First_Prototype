using System;
using UnityEngine;

namespace ScriptableObjects.Prototypes.Trait {
    [CreateAssetMenu(fileName = "LinearAccelerateTraits", menuName = "Traits/Linear Accelerate", order = 0)]

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