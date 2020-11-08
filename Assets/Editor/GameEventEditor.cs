using Events;
using UnityEngine;
using UnityEditor;

/// <summary>
///     Adds GUI elements for raising events
/// </summary>
/// <remarks>
///     Source: McVicker's github
///     https://github.com/StephenMcVicker/Unity-ScriptableObjects-Game-Events-
/// </remarks>
[CustomEditor(typeof(GameEvent))]
public class GameEventEditor : Editor {
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        GameEvent _GE = target as GameEvent;

        if (GUILayout.Button("Raise")) {
            _GE.Raise();
        }
    }
}
