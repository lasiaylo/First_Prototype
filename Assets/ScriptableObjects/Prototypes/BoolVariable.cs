using System;
using UnityEngine;

namespace ScriptableObjects.Prototypes {
    [CreateAssetMenu(fileName = "Bool", menuName = "Variable/Bool", order = 0)]
    public class BoolVariable : DefaultScriptableObject {
        [SerializeField] private bool Val;
        public bool val;
        
        public override void OnAfterDeserialize() {
            val = Val;
        }
    }
}