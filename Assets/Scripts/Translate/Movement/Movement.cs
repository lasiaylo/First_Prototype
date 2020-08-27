using System.Collections.Generic;
using UnityEngine;
using Util.Attributes;

namespace Translate.Movement {
    /// <summary>
    /// Handles GameObject Movement. 
    /// </summary>
    /// <remarks>
    /// Adapted from Dapper Dino's design:https://forum.unity.com/threads/editor-tool-better-scriptableobject-inspector-editing.484393/
    /// https://github.com/DapperDino/Dapper-Tools/tree/master/Runtime/Components/Movements
    /// </remarks>
    [RequireComponent(typeof(CharacterController))]
    public class Movement: MonoBehaviour {
        [SerializeField] private Vector3 direction;
        [Expandable] public List<MovementMod> modifiers = new List<MovementMod>();
        private CharacterController _controller;

        public Vector3 Direction {
            get => enabled ? direction : Vector3.zero;
            private set => direction = value;
        }

        public void Awake() {
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
    }
}