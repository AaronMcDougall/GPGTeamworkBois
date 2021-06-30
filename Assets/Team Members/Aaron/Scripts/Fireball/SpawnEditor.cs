using System.Collections;
using System.Collections.Generic;
using Fireball;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SpawnPoints))]
public class SpawnEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Update Spawnpoint CoOrd"))
        {
            ((SpawnPoints) target).GetSpawns();
        }
    }
}
