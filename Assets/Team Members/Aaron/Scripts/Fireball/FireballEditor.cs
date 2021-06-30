using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Fireball.Fireball))]

public class FireballEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Spawn Fireball"))
        {
            ((Fireball.Fireball) target).FireballSpawn();
        }
    }
}
