using UnityEditor;
using UnityEngine;
using John;

[CustomEditor(typeof(RockWall))]
public class RockEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Shoot Rocks"))
        {
            (target as RockWall)?.StartShoot();
        }
    }
}

    