using System;
using System.Collections;
using System.Collections.Generic;
using States;
using States.Player;
using UnityEngine;

public class RunDustAnimator : MonoBehaviour {
    private ParticleSystem _particleSystem;
    public void Awake() {
        _particleSystem = GetComponent<ParticleSystem>();
    }

    public void Trigger(State state) {
        MovableState playerState = (MovableState) state;
        if (playerState.PlayerState == PlayerState.Run) {
            if (playerState.phase == Phase.Start)
                _particleSystem.Play();
        } else {
            _particleSystem.Stop();
        }
    }
}