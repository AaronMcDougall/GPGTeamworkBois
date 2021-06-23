using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MusicManager))]
public class EditorButton : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Start Music"))
        {
            (target as MusicManager)?.RPCStartMusic();
        }
        
        /**
        if (GUILayout.Button("Start Timer"))
        {
            (target as MusicManager)?.RPCTimerGo();
        }

        if (GUILayout.Button("Stop Timer"))
        {
            (target as MusicManager)?.RPCTimerStop();
        }
        **/
    }
}


