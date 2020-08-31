using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjects.Prototypes.Event {
    public class GameEventListener<T> : MonoBehaviour {
        [SerializeField] private GameEvent<T> _gameEvent;
        [SerializeField] private UnityEvent<T> _response;
        public void OnEventRaised(T val) {
            
        }

        public void OnEnable() {
            _gameEvent.RegisterListener(this);
        }

        public void OnDisable() {
            _gameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(T val) {
            _response.Invoke(val);
        }
    }
}