using UnityEngine;

namespace States {
    public interface IState {
        void Enter(GameObject player);

        void Update(GameObject player);

        void FixedUpdate(GameObject player);

        void Exit(GameObject player);
    }
}
