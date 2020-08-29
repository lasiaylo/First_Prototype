using System;
using UnityEngine;
using Util;

namespace ScriptableObjects.Prototypes {
    [CreateAssetMenu]
    public class JumpTraits : ScriptableObject, ISerializationCallbackReceiver {
        [SerializeField] private Action action;
        [SerializeField] private float duration;
        [SerializeField] private float speed;
        [SerializeField] private float continueSpeed;
        [SerializeField] private float threshold;

        [NonSerialized] public Action Action;
        [NonSerialized] public float Duration;
        [NonSerialized] public float Speed;
        [NonSerialized] public float ContinueSpeed;
        [NonSerialized] public float Threshold;
        
        public Timer Timer;

        public void OnAfterDeserialize() {
            Action = action;
            Duration = duration;
            Speed = speed;
            ContinueSpeed = continueSpeed;
            Threshold = threshold;
        }
        
        public void OnBeforeSerialize() { }
    }    
}