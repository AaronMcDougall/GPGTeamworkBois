using UnityEngine;
using UnityEditor;
using John;


[CustomEditor(typeof(GameManager))]
public class MusicEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Music Play"))
        {
            (target as GameManager)?.PlayMusic();
        }
        
        if (GUILayout.Button("Start Timer"))
        {
            (target as GameManager)?.PlayTimer();
        }
    }
}
