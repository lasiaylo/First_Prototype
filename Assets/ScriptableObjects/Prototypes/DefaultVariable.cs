using UnityEngine;

namespace ScriptableObjects.Prototypes {
public abstract class DefaultVariable<T> : DefaultScriptableObject {
    [SerializeField] private T defaultVal;
    public T val;

    public override void ResetToDefault() {
        val = defaultVal;
    }

}
}