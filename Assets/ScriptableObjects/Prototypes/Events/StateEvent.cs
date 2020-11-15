using Events;
using States;
using UnityEngine;

namespace ScriptableObjects.Prototypes.Events {
    [CreateAssetMenu(fileName = "StateEvent", menuName = "Events/State", order = 0)]
    public class StateEvent : GameEvent<State> { }
} 