using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TaskWindow : EditorWindow
{
    bool groupEnabled;
    bool myBool = true;
    public Object source;
    int objectAmount;
    float myFloat = 1f;

    [MenuItem("Custom Windows/Task Window")]
    static void Init()
    {
        TaskWindow window = (TaskWindow)EditorWindow.GetWindow(typeof(TaskWindow));
        window.Show();
    }
    void OnGUI()
    {
        GUILayout.Label("Object Spawning", EditorStyles.boldLabel);

        EditorGUILayout.BeginHorizontal();
        source = EditorGUILayout.ObjectField("Insert Object", source, typeof(Object), true);
        EditorGUILayout.EndHorizontal();
        objectAmount = EditorGUILayout.IntField("Object Amount", objectAmount);
        myFloat = EditorGUILayout.Slider("Spawn Area Range", myFloat, 0, 100);
        


        if(EditorGUILayout.LinkButton("Spawn Objects"))
        {

        }
        // Start is called before the first frame update
    }
}
