using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Aaron
{
    [CustomEditor(typeof(StateBase), true)]
    public class StateBaseEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            GUILayout.BeginHorizontal();
            
            if(GUILayout.Button("Force Enter"))
            {
                ((StateBase)target).Enter();
            }

            if (GUILayout.Button("Force Execute"))
            {
                ((StateBase)target).Execute();
            }

            if (GUILayout.Button("Force Exit"))
            {
                ((StateBase)target).Exit();
            }

            GUILayout.EndHorizontal();

        }
    }

}
