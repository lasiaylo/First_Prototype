using UnityEngine;

namespace ScriptableObjects.Prototypes {
    [CreateAssetMenu(fileName = "Vector", menuName = "Variable/Vector 3", order = 0)]

    public class Vector3Variable : DefaultScriptableObject {
        [SerializeField] private Vector3 defaultVal;
        public Vector3 val;
        
        public override void OnAfterDeserialize() {
            defaultVal = val;
        }
        
    }
}