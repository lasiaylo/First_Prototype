using UnityEngine;

namespace ScriptableObjects.Prototypes {
/// <summary>
///     Scriptable Object that resets value to default
/// </summary>
public abstract class DefaultScriptableObject : ScriptableObject, ISerializationCallbackReceiver {
    public abstract void ResetValue();

    public virtual void OnBeforeSerialize() { }
}
}