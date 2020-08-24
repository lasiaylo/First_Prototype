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
        private CharacterController _controller;

        private Vector3 _direction;

        public Vector3 Direction {
            get => enabled ? _direction : Vector3.zero;
            private set => _direction = value;
        }

        public Vector3 PrevDirection { get; private set; }
        
        public List<MovementMod> modifiers = new List<MovementMod>();

        public void Start() {
            _controller = GetComponent<CharacterController>();
        }

        public void Tick(float deltaTime) {
            foreach (MovementMod mod in modifiers) {
                if (mod.enabled)
                    Direction = mod.Modify(Direction);
            }
            _controller.Move(Direction * deltaTime);
            PrevDirection = Direction;
        }

        public void Tick() {
            Tick(Time.deltaTime);
        }

        public void AddModifier(MovementMod mod) => modifiers.Add(mod);

        public void RemoveModifier(MovementMod mod) => modifiers.Add(mod);
    }
}