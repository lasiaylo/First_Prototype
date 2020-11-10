using System;
using UnityEngine;

namespace ScriptableObjects.Prototypes.Trait {
[CreateAssetMenu(fileName = "LinearAccelerateTraits", menuName = "Traits/Linear Accelerate", order = 0)]
public class LinearAccelerateTraits : DefaultScriptableObject {
    [NonSerialized] public float Acceleration;
    [NonSerialized] public float Deceleration;
    [NonSerialized] public Vector3 MaxSpeed;
    [SerializeField] private float acceleration = 0;
    [SerializeField] private float deceleration = 0;
    [SerializeField] private Vector3 maxSpeed = Vector3.one;

    public override void ResetToDefault() {
        Acceleration = acceleration;
        Deceleration = deceleration;
        MaxSpeed = maxSpeed;
    }
}
}