using System;
using UnityEngine;

public class PlayerMovement: MonoBehaviour {
    public float Speed { get; set; }
    
    public Vector3 Velocity { get; set; }
    
    public void Awake() {
        Speed = 0;
        Velocity = new Vector3();
    }
}