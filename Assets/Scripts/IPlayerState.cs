using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerState {
    void Start(PlayerController player);

    void Update(PlayerController player);

    void FixedUpdate(PlayerController player);

    void Exit(PlayerController player);
}
