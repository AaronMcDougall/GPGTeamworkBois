using System.Collections;
using System.Collections.Generic;
using Fireball;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(FireballSpawnPoints))]
public class SpawnEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Spawn Items"))
        {
            ((FireballSpawnPoints)target).StartCoroutine("SpawnItem");
        }
    }
}
