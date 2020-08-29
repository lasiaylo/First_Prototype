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
    public class Movement: Modifier<Vector3> {
        private CharacterController _controller;

        public Vector3 Value {
            get => enabled ? val : Vector3.zero;
            private set => val = value;
        }

        public void Awake() {
            _controller = GetComponent<CharacterController>();
        }

        public override void Tick() {
            base.Tick();
            _controller.Move(val * Time.deltaTime);
        }
    }
}