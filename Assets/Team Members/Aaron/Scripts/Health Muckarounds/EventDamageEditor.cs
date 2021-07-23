using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DamageEvent))]

public class EventDamageEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if(GUILayout.Button("Fire Damage Event"))
        {
            ((DamageEvent)target).CallDamageEvent();
        }
    }
}

