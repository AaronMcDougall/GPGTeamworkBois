using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEditor;
using UnityEngine;


namespace Aaron
{
    [CustomEditor(typeof(StateBase), true)]
    public class StateBaseEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            //base.OnInspectorGUI();
            
            GUILayout.BeginHorizontal();

            if (GUILayout.Button("Force Enter"))
            {
                ((StateBase) target).Enter();
            }
            
            if (GUILayout.Button("Force Enter"))
            {
                ((StateBase) target).Execute();
            }
            
            if (GUILayout.Button("Force Enter"))
            {
                ((StateBase) target).Exit();
            }
            
            GUILayout.EndHorizontal();

            if (GUILayout.Button("Change State"))
            {
                
            }
        }
    }
}

