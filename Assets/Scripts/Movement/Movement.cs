using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Movement {
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
        [SerializeField] private List<IMovementModifier> modifiers = new List<IMovementModifier>();
    
        public void Awake() {
            _controller = GetComponent<CharacterController>();
        }

        public void AddModifier(IMovementModifier mod) => modifiers.Add(mod);

        public void RemoveModifier(IMovementModifier mod) => modifiers.Add(mod);

        public void Move(float deltaTime) {
            Vector3 direction = modifiers.Aggregate(Vector3.zero,
                (current, mod) => current + mod.Direction);
            _controller.Move(direction * deltaTime);
        }

        public void Move() {
            Move(Time.deltaTime);
        }
    }
}