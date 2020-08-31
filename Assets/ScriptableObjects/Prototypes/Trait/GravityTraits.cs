using System;
using UnityEngine;

namespace ScriptableObjects.Prototypes.Trait {
[CreateAssetMenu(fileName = "GravityTraits", menuName = "Traits/Gravity", order = 0)]
public class GravityTraits : DefaultScriptableObject {
    [SerializeField] private float arcMult;
    [NonSerialized] public float ArcMult;
    [SerializeField] private float arcThreshold;
    [NonSerialized] public float ArcThreshold;
    [SerializeField] private float gravity;

    [NonSerialized] public float Gravity;
    [SerializeField] private float groundGravity;
    [NonSerialized] public float GroundGravity;
    [SerializeField] private float maxFallSpeed;
    [NonSerialized] public float MaxFallSpeed;

    public override void ResetToDefault() {
        Gravity = gravity;
        GroundGravity = groundGravity;
        ArcMult = arcMult;
        ArcThreshold = arcThreshold;
        MaxFallSpeed = maxFallSpeed;
    }
}
}