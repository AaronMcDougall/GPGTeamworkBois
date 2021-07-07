using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Menu
{
    [CustomEditor(typeof(MenuState))]
    public class MenuStateEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if(GUILayout.Button("Enter Menu State"))
            {
                ((MenuState)target).Enter();
            }
        }
    }
}

