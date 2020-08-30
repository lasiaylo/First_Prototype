using UnityEngine;

namespace ScriptableObjects.Prototypes.Variables {
    [CreateAssetMenu(fileName = "Bool", menuName = "Variable/Bool", order = 0)]
    public class BoolVariable : DefaultScriptableObject {
        [SerializeField] private bool defaultVal;
        public bool val;
        
        public override void OnAfterDeserialize() {
            val = defaultVal;
        }
    }
}