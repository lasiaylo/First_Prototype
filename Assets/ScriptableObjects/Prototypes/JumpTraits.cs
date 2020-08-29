using System;
using UnityEngine;
using Util;

namespace ScriptableObjects.Prototypes {
    [CreateAssetMenu]
    public class JumpTraits : LockedScriptableObject {
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