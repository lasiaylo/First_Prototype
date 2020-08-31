﻿using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjects.Prototypes.Event {
    public class GameEventListener<T> : MonoBehaviour {
        [SerializeField] private GameEvent<T> gameEvent;
        [SerializeField] private UnityEvent<T> response;

        public void OnEnable() {
            gameEvent.RegisterListener(this);
        }

        public void OnDisable() {
            gameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(T val) {
            response.Invoke(val);
        }
    }
}