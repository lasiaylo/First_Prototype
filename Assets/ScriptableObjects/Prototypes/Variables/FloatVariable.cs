using System;
using UnityEngine;

namespace ScriptableObjects.Prototypes.Variables {
    [CreateAssetMenu(fileName = "Float", menuName = "Variables/Float", order = 0)]

    public class FloatVariable : DefaultScriptableObject {
        [SerializeField] private float defaultVal;
        [NonSerialized] public float val;
        
        public override void OnAfterDeserialize() {
            val = defaultVal;
        }
    }
}