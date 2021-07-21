using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SaveLoad))]
public class SaveLoadEditor : Editor
{

    public SaveLoad saveLoad;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if(GUILayout.Button("Save"))
        {
            ((SaveLoad)target).SaveVariables();
        }

        if(GUILayout.Button("Load"))
        {
            ((SaveLoad)target).LoadVariables();
        }
    }

}
