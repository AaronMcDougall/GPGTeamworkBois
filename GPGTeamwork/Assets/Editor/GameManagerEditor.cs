using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GameManager))]
public class GameManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Start Timer"))
        {
            (target as GameManager)?.RPCStartTimer();
        }

        if (GUILayout.Button("Stop Timer"))
        {
            (target as GameManager)?.RPCStopTimer();
        }
    }
}