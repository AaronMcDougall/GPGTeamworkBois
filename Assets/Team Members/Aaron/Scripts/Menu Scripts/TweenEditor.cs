using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;

namespace Menu
{
    [CustomEditor(typeof(TitleTween))]
    public class TweenEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if(GUILayout.Button ("Run Title Drop"))
            {
                ((TitleTween)target).TitleDrop();
            }
        }
    }
}
