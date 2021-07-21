using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;

[CustomEditor(typeof(DamageDealt))]
public class TakeDamageScript : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if(GUILayout.Button("Deal Damage"))
        {
            ((DamageDealt)target).DealDamage();
        }
    }

}
