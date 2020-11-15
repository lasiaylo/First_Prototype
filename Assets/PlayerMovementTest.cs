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
    private Toggle _toggle;
    
    public void Start() {
        _directions = new List<Vector3>() {
            Vector3.right,
            Vector3.left,
        };
        _toggle = new Toggle(false);
        StartCoroutine(Move());
    }

    private IEnumerator Move() {
        for (;;) {
            inputDirection.Val = _directions[_toggle];
            yield return new WaitForSeconds(duration);
            _toggle.Flip();
        }
    }
}
