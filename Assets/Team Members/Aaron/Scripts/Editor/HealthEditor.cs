using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Health))]
public class HealthEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();       

        if (GUILayout.Button("Death"))
        {
            ((Health)target).CallDeathEvent();
        }
    }

    
}
