using System;
using UnityEngine;

namespace ScriptableObjects.Prototypes {
    [CreateAssetMenu]
    public class TurnTraits : DefaultScriptableObject {
        [SerializeField] private float turnSpeed;
        [SerializeField] private Vector3 direction;

        [NonSerialized] public float TurnSpeed;
        [NonSerialized] public Vector3 Direction;
        
        public override void OnAfterDeserialize() {
            TurnSpeed = turnSpeed;
            Direction = direction;
        }
    }
}