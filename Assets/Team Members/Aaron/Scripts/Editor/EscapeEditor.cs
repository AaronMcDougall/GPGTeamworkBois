using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Menu
{
    [CustomEditor(typeof(EscapeEventManager))]
    public class EscapeEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if(GUILayout.Button("Run Escape"))
            {
                ((EscapeEventManager)target).RunEscapeMenu();
            }

            if(GUILayout.Button("Run Return"))
            {
                ((EscapeEventManager)target).RunReturnEvent();
            }
        }
    }
}

