using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Motion {
    /// <summary>
    /// Handles GameObject Movement. 
    /// </summary>
    /// <remarks>
    /// Adapted from Dapper Dino's design seen on
    /// github.com/DapperDino/Dapper-Tools/tree/master/Runtime/Components/Movements
    /// </remarks>
    [RequireComponent(typeof(CharacterController))]
    public class Movement: MonoBehaviour {
        public List<MovementMod> modifiers = new List<MovementMod>();
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
            Direction = modifiers.Aggregate(Vector3.zero,
                (current, mod) => current + mod.Direction);
            _controller.Move(Direction * deltaTime);
        }

        public void Tick() {
            Tick(Time.deltaTime);
        }

        public void AddModifier(MovementMod mod) => modifiers.Add(mod);

        public void RemoveModifier(MovementMod mod) => modifiers.Add(mod);
    }
}