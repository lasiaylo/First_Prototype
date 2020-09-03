using System;
using UnityEngine;
using Util;

namespace ScriptableObjects.Prototypes.Trait {
[CreateAssetMenu(fileName = "JumpTraits", menuName = "Traits/Jump", order = 0)]
public class JumpTraits : DefaultScriptableObject {
    [SerializeField] private float speed;
    [SerializeField] private Phase phase;

    [NonSerialized] public float Speed;
    [NonSerialized] public Phase Phase;

    public Timer timer;

    public override void ResetToDefault() {
        Phase = phase;
        Speed = speed;
        timer.Reset();
    }
}
}