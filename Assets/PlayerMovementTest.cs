using System.Collections;
using System.Collections.Generic;
using ScriptableObjects.Prototypes.Variable;
using UnityEngine;
using Util;
using Util.Attributes;

public class PlayerMovementTest : MonoBehaviour {
    [Expandable] public Vector3Variable inputDirection;
    public float duration;
    private List<Vector3> _directions;
    public void Start() {
        _directions = new List<Vector3>() {
            Vector3.forward,
            Vector3.right,
            Vector3.back,
            Vector3.right,
        };
    }

    // public void Update() {
    //     StartCoroutine(Move());
    // }

    private IEnumerator Move() {
        for (int i = 0; i < _directions.Count; i++) {
            inputDirection.Val = _directions[i];
            Debug.Log(_directions[i]);
            // if (_directions[i] != Vector3.forward) Debug.Break();
            yield return new WaitForSeconds(duration);
        }
        // foreach (Vector3 direction in _directions) {
        //     inputDirection.val = direction;
        //     Debug.Log(direction);
        //     yield return null;
        // }
    }
}
