using System.Collections;
using System.Collections.Generic;
using States;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private PoolStateMachine _poolStateMachine;
    // Start is called before the first frame update
    void Start() {
  }

    // Update is called once per frame
    void Update() {
        _poolStateMachine.Update();
        Debug.Log("YO");
    }
}
