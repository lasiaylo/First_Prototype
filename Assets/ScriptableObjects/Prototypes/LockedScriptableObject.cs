﻿using UnityEngine;

namespace ScriptableObjects.Prototypes {
    /// <summary>
    /// Scriptable Object that resets value to default
    /// </summary>
    public abstract class LockedScriptableObject : ScriptableObject, ISerializationCallbackReceiver {
        public abstract void OnAfterDeserialize();
        public void OnBeforeSerialize() { }
    }
}