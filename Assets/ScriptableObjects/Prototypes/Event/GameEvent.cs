using System.Collections.Generic;
using UnityEngine;
using Util.Attributes;

namespace ScriptableObjects.Prototypes.Event {
    public abstract class GameEvent<T> : ScriptableObject {
        [Expandable] public List<GameEventListener<T>> listeners = new List<GameEventListener<T>>();
    
        [ContextMenu("Raise Event")]
        public void Raise(T val) {
            for (int i = listeners.Count - 1; i >= 0; i--) {
                listeners[i].OnEventRaised(val);
            }
        }

        public void RegisterListener(GameEventListener<T> listener) {
            listeners.Add(listener);
        }

        public void UnregisterListener(GameEventListener<T> listener) {
            listeners.Remove(listener);
        }
    }
}