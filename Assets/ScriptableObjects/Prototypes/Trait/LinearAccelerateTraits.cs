using System;
using UnityEngine;

namespace ScriptableObjects.Prototypes.Trait {
[CreateAssetMenu(fileName = "LinearAccelerateTraits", menuName = "Traits/Linear Accelerate", order = 0)]
public class LinearAccelerateTraits : DefaultScriptableObject {
    [SerializeField] private float acceleration;

    [NonSerialized] public float Acceleration;
    [SerializeField] private float deceleration;
    [NonSerialized] public float Deceleration;
    [SerializeField] private Vector3 maxSpeed;
    [NonSerialized] public Vector3 MaxSpeed;

    public override void OnAfterDeserialize() {
        Acceleration = acceleration;
        Deceleration = deceleration;
        MaxSpeed = maxSpeed;
    }
}
}