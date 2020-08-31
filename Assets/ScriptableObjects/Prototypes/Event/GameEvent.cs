using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects.Prototypes.Event {
    public abstract class GameEvent<T> : ScriptableObject {
        private readonly List<GameEventListener<T>> _listeners = new List<GameEventListener<T>>();

        public void Raise(T val) {
            for (int i = _listener.Count - 1; i >= 0; i--) {
                _listeners[i].OnEventRaised(val);
            }
        }

        public void RegisterListener(GameEventListener<T> listener) {
            _listeners.Add(listener);
        }

        public void UnregisterListener(GameEventListener<T> listener) {
            _listeners.Remove(listener);
        }
        
        

    }
}