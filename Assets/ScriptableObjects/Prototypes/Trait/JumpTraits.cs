using System;
using UnityEngine;
using Util;

namespace ScriptableObjects.Prototypes.Trait {
    [CreateAssetMenu(fileName = "JumpTraits", menuName = "Traits/Jump", order = 0)]
    public class JumpTraits : DefaultScriptableObject {
        [SerializeField] private Action action;
        [SerializeField] private float duration;
        [SerializeField] private float speed;

        [NonSerialized] public Action Action;
        [NonSerialized] public float Duration;
        [NonSerialized] public float Speed;
        
        public Timer timer;

        public override void OnAfterDeserialize() {
            Action = action;
            Duration = duration;
            Speed = speed;
        }
    }    
}