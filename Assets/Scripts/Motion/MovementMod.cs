using System;
using UnityEngine;

namespace Motion {
    public abstract class MovementMod : MonoBehaviour {
        public Vector3 Direction { get; protected set; }

        protected bool Enabled {
            get;
            private set;
        }

        public void OnEnable() {
            Enabled = true;
        }

        public void OnDisable() {
            Enabled = false;
        }
    }
}