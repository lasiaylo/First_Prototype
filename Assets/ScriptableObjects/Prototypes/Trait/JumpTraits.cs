using System;
using UnityEngine;
using Util;

namespace ScriptableObjects.Prototypes.Trait {
[CreateAssetMenu(fileName = "JumpTraits", menuName = "Traits/Jump", order = 0)]
public class JumpTraits : DefaultScriptableObject {
    [SerializeField] private float duration;
    [NonSerialized] public float Duration;
    [SerializeField] private Phase phase;

    [NonSerialized] public Phase Phase;
    [SerializeField] private float speed;
    [NonSerialized] public float Speed;

    public Timer timer;

    public override void OnAfterDeserialize() {
        Phase = phase;
        Duration = duration;
        Speed = speed;
    }
}
}