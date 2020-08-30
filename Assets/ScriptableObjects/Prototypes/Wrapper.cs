using UnityEngine;
using UnityEngine.Serialization;

namespace ScriptableObjects.Prototypes {
    public class Wrapper<T> : DefaultScriptableObject where T: ScriptableObject {
        [SerializeField] private T defaultObj;
        public T obj;

        public void Reset() {
            obj = defaultObj;
        }

        public override void OnAfterDeserialize() {
            Reset();
        }
    }
}