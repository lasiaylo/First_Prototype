using System;
using UnityEngine;
using Util;

namespace ScriptableObjects.Prototypes.Trait {
    [CreateAssetMenu(fileName = "JumpTraits", menuName = "Traits/Jump", order = 0)]
    public class JumpTraits : DefaultScriptableObject {
        [SerializeField] private Phase phase;
        [SerializeField] private float duration;
        [SerializeField] private float speed;

        [NonSerialized] public Phase Phase;
        [NonSerialized] public float Duration;
        [NonSerialized] public float Speed;
        
        public Timer timer;

        public override void OnAfterDeserialize() {
            Phase = phase;
            Duration = duration;
            Speed = speed;
        }
    }    
}