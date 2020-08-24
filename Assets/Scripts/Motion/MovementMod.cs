using System;
using UnityEngine;

namespace Motion {
    public abstract class MovementMod : MonoBehaviour {
        public abstract Vector3 Influence(Vector3 direction);

        /// <summary>
        /// Left in so enable checkbox appears in Inspector
        /// </summary>
        public void OnEnable() { }
        
    }
}