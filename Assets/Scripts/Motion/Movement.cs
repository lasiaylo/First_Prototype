using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Util.Attributes;

namespace Motion {
    /// <summary>
    /// Handles GameObject Movement. 
    /// </summary>
    /// <remarks>
    /// Adapted from Dapper Dino's design:https://forum.unity.com/threads/editor-tool-better-scriptableobject-inspector-editing.484393/
    /// https://github.com/DapperDino/Dapper-Tools/tree/master/Runtime/Components/Movements
    /// </remarks>
    [RequireComponent(typeof(CharacterController))]
    public class Movement: MonoBehaviour {
        [Expandable] public List<MovementMod> modifiers = new List<MovementMod>();
        private CharacterController _controller;
        private Vector3 _direction;

        public Vector3 Direction {
            get => enabled ? _direction : Vector3.zero;
            private set => _direction = value;
        }

        public void Start() {
            _controller = GetComponent<CharacterController>();
        }

        public void Tick(float deltaTime) {
            foreach (MovementMod mod in modifiers) {
                if (mod.enabled)
                    Direction = mod.Modify(Direction);
            }
            _controller.Move(Direction * deltaTime);
        }

        public void Tick() {
            Tick(Time.deltaTime);
        }

        public void AddModifier(MovementMod mod) => modifiers.Add(mod);

        public void RemoveModifier(MovementMod mod) => modifiers.Add(mod);
    }
}