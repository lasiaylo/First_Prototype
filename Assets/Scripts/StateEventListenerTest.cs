using States;
using UnityEngine;

public class StateEventListenerTest : MonoBehaviour {
    public void Test(State state) {
        Debug.Log(state);
    }

    public void TestString(string message) {
        Debug.Log(message);
    }
}