using System;
using UnityEngine;

namespace ScriptableObjects.Prototypes.Trait {
[CreateAssetMenu(fileName = "GravityTraits", menuName = "Traits/Gravity", order = 0)]
public class GravityTraits : DefaultScriptableObject {
    [NonSerialized] public float ArcMult;
    [NonSerialized] public float ArcThreshold;
    [NonSerialized] public float Gravity;
    [NonSerialized] public float GroundGravity;
    [NonSerialized] public float MaxFallSpeed;
    [SerializeField] private float arcMult = 0;
    [SerializeField] private float arcThreshold = 0;
    [SerializeField] private float gravity = 0;
    [SerializeField] private float groundGravity = 0;
    [SerializeField] private float maxFallSpeed = 0;

    public override void ResetToDefault() {
        Gravity = gravity;
        GroundGravity = groundGravity;
        ArcMult = arcMult;
        ArcThreshold = arcThreshold;
        MaxFallSpeed = maxFallSpeed;
    }
}
}