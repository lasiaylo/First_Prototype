using UnityEngine;

namespace Translate.Movement {
    public abstract class Mod<T> : MonoBehaviour {
        public abstract T Modify(T direction);

        /// <summary>
        /// Left in so enable checkbox appears in Inspector
        /// </summary>
        public void OnEnable() { }
    }
}