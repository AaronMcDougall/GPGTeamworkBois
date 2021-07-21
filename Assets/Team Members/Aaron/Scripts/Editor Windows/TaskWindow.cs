using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TaskWindow : EditorWindow
{
    //allows to drag in object/prefab
    public Object source;
    //the amount of objects they want to spawn per click
    int objectAmount;
    float myFloat = 1f;

    public List<Object> lastSpawned = new List<Object>();

    //window access in menu
    [MenuItem("Custom Windows/Task Window")]
    static void Init()
    {
        TaskWindow window = (TaskWindow)EditorWindow.GetWindow(typeof(TaskWindow));
        window.Show();
    }

    //creates the window
    void OnGUI()
    {
        GUILayout.Label("Object Spawning", EditorStyles.boldLabel);

        //input fields
        source = EditorGUILayout.ObjectField("Object to Spawn", source, typeof(Object), false);
        objectAmount = EditorGUILayout.IntField("Amount to Spawn", objectAmount);
        myFloat = EditorGUILayout.Slider("Spawn Area Range", myFloat, 0, 100);
        
        //Button which will spawn objects based on various previous inputs
        if(GUILayout.Button("Spawn Objects"))
        {
            if (objectAmount > 0)
            {
                for (int i = 0; i < objectAmount; i++)
                {
                    Instantiate(source, new Vector3((Random.Range(0, myFloat)), (Random.Range(0, myFloat)), 0), Quaternion.Euler(0, 0, 0));
                    //trials
                    lastSpawned.Add(source);
                }
            }            
        }

        if(GUILayout.Button("Delete Last"))
        {
            Debug.Log(lastSpawned.Count);
           //want to find a way to select the last spawns and delete them, as a kind of undo button
           //should each object in the last spawn action be added to a list and do it that way?
        }
    }
}
