using System;
using UnityEngine;
using Util;

namespace ScriptableObjects.Prototypes.Trait {
[CreateAssetMenu(fileName = "JumpTraits", menuName = "Traits/Jump", order = 0)]
public class JumpTraits : DefaultScriptableObject {
    [NonSerialized] public float Speed;
    [NonSerialized] public Phase Phase;
    [SerializeField] private float speed = 0;
    [SerializeField] private Phase phase = 0;

    public Timer timer;

    public override void ResetToDefault() {
        Phase = phase;
        Speed = speed;
        timer.Reset();
    }
}
}