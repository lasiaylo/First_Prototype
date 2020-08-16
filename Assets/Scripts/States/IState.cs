﻿using UnityEngine;

namespace States {
    public interface IState {
        void Enter();

        void Update();

        void FixedUpdate();

        void Exit();
    }
}
