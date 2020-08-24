using System;
using UnityEngine;

namespace ScriptableObjects {
[CreateAssetMenu]
    public class JumpTraits : ScriptableObject, ISerializationCallbackReceiver {
        private Action _initAction;
        private float _initDuration;
        private float _initSpeed;

        [NonSerialized] public Action Action;
        [NonSerialized] public float Duration;
        [NonSerialized] public float Speed;

        public void OnAfterDeserialize() {
            Action = _initAction;
            Duration = _initDuration;
            Speed = _initSpeed;
        }
        
        public void OnBeforeSerialize() { }
    }    
}