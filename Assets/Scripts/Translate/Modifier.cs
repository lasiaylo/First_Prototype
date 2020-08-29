using System.Collections.Generic;
using Translate.Movement;
using UnityEngine;
using Util.Attributes;

namespace Translate {
    /// <summary>
    /// Maintains a value that is modified through a list of Mods 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Modifier<T>: MonoBehaviour {
        [SerializeField] protected T val;
        [Expandable] public List<Mod<T>> mods = new List<Mod<T>>();
        
        public virtual void Tick() {
            foreach (Mod<T> mod in mods) {
                if (mod.enabled)
                    val = mod.Modify(val);
            }
        }
    }
}