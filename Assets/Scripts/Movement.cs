using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement: MonoBehaviour {
    public float Speed { get; private set; }
    
    public Vector3 Velocity { get; private set; }
    
    public CharacterController Controller { get; private set; }
    
    public void Awake() {
        Speed = 0;
        Velocity = new Vector3();
        Controller = GetComponent<CharacterController>();
    }

    public void Move(Vector3 direction) {
        if (direction.magnitude >= 0.1f) {
            Controller.Move(direction * Speed * Time.deltaTime);
        }
    }
}