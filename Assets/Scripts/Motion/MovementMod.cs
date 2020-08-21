using System;
using UnityEngine;

namespace Motion {
    public abstract class MovementMod : MonoBehaviour {
        public Vector3 Direction { get; protected set; }

        /// <summary>
        /// Left in so enable checkbox appears in Inspector
        /// </summary>
        public void OnEnable() { }
    }