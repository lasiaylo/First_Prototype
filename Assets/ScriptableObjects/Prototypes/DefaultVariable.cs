using UnityEngine;

namespace ScriptableObjects.Prototypes {
    public abstract class DefaultVariable<T> : DefaultScriptableObject {
        [SerializeField] private T defaultVal;
        public T val;

        public void Reset() {
            val = defaultVal;
        }
        public override void OnAfterDeserialize() {
            Reset();
        }
    }
}