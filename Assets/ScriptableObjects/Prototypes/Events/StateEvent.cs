using Events;
using States;
using UnityEngine;

namespace ScriptableObjects.Events {
    [CreateAssetMenu(fileName = "StateEvent", menuName = "StateEvent", order = 0)]
    public class StateEvent : GameEvent<State> { }
}