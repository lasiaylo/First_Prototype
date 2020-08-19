using System;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(CharacterController))]
public class Movement: MonoBehaviour {
    [SerializeField] private float speed;
    
    public Vector3 Velocity { get; private set; }
    
    public CharacterController Controller { get; private set; }
    
    public void Awake() {
        Velocity = new Vector3();
        Controller = GetComponent<CharacterController>();
    }

    public void Move(Vector3 direction) {
        if (direction.magnitude >= 0.1f) {
            Controller.Move(direction * speed * Time.deltaTime);
        }
    }
}