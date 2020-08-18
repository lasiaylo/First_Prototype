using UnityEngine;

namespace Movement {
    public interface IMovementModifier {
        Vector3 Direction { get; }        
    }
}