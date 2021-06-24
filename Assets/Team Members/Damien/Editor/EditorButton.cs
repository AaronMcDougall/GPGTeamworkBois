using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Damien;
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
    }
}


