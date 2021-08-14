using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TaskWindow : EditorWindow
{
    //allows to drag in object/prefab
    public GameObject source;
    public GameObject copy;

    //the amount of objects they want to spawn per click
    public int objectAmount;

    //Location x coordinates
    public float xMin = 0;
    public float xMinLimit = 0;
    public float xMax = 100;
    public float xMaxLimit = 100;
 
    //Location z coordinates
    public float zMin = 0;
    public float zMinLimit = 0;
    public float zMax = 100;
    public float zMaxLimit = 100;

    //Rotation x values
    public float xRotMin = 0;
    public float xRotMinLimit = 0;
    public float xRotMax = 359;
    public float xRotMaxLimit = 359;

    //Rotation z values
    public float zRotMin = 0;
    public float zRotMinLimit = 0;
    public float zRotMax = 359;
    public float zRotMaxLimit = 359;

    //List for last spawned group of objects
    public List<GameObject> lastSpawned = new List<GameObject>();
    public List<GameObject> allSpawned = new List<GameObject>();

    //Vertical scroll variable
    public Vector2 scrollPos;

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
        scrollPos = EditorGUILayout.BeginScrollView(scrollPos);

        GUILayout.Label("Object Spawning", EditorStyles.boldLabel);

        //Object input fields
        source = (GameObject)EditorGUILayout.ObjectField("Object to Spawn", source, typeof(GameObject), false);
        objectAmount = EditorGUILayout.IntField("Amount to Spawn", objectAmount);

        //Location Settings
        GUILayout.Label("Spawn Location Ranges", EditorStyles.boldLabel);
        //Display current, set new X values for spawn location
        GUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Minimum X Value: ", xMin.ToString());
        EditorGUILayout.LabelField("Maximum X Value: ", xMax.ToString());
        GUILayout.EndHorizontal();
        EditorGUILayout.MinMaxSlider(ref xMin, ref xMax, xMinLimit, xMaxLimit);
        //Diplay current, set new Z values for spawn location
        GUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Minimum Z Value: ", zMin.ToString());
        EditorGUILayout.LabelField("Minimum Z Value: ", zMax.ToString());
        GUILayout.EndHorizontal();
        EditorGUILayout.MinMaxSlider(ref zMin, ref zMax, zMinLimit, zMaxLimit);


        //Rotation Settings
        GUILayout.Label("Spawn Rotation Ranges", EditorStyles.boldLabel);
        //Display current, set new x values for spawn rotation
        GUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Minimum X Value: ", xRotMin.ToString());
        EditorGUILayout.LabelField("Maximum X Value: ", xRotMax.ToString());
        GUILayout.EndHorizontal();
        EditorGUILayout.MinMaxSlider(ref xRotMin, ref xRotMax, xRotMinLimit, xRotMaxLimit);
        //Display current, set new Z values for spawn rotation
        GUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Minimum Z Value: ", zRotMin.ToString());
        EditorGUILayout.LabelField("Maximum Z Value: ", zRotMax.ToString());
        GUILayout.EndHorizontal();
        EditorGUILayout.MinMaxSlider(ref zRotMin, ref zRotMax, zRotMinLimit, zRotMaxLimit);


        //Button which will spawn objects based on various previous inputs
        if (GUILayout.Button("Spawn Objects"))
        {
            lastSpawned.Clear();
            if (objectAmount > 0)
            {
                for (int i = 0; i < objectAmount; i++)
                {                    
                    GameObject copy = Instantiate(source, new Vector3((Random.Range(xMin, xMax)), 0, (Random.Range(zMin, zMax))), 
                    Quaternion.Euler((Random.Range(xRotMin, xRotMax)), 0, (Random.Range(zRotMin, zRotMax))));           

                    lastSpawned.Add(copy);
                    allSpawned.Add(copy);
                }                
            }
        }

        //Button to clear all values 
        if(GUILayout.Button("Reset all values"))
        {         
            xMin = 0;
            xMinLimit = 0;
            xMax = 100;
            xMaxLimit = 100;

            zMin = 0;
            zMinLimit = 0;
            zMax = 100;
            zMaxLimit = 100;

            xRotMin = 0;
            xRotMinLimit = 0;
            xRotMax = 359;
            xRotMaxLimit = 359;

            zRotMin = 0;
            zRotMinLimit = 0;
            zRotMax = 359;
            zRotMaxLimit = 359;
        }

        //Button to delete last group of spawned objects
        if(GUILayout.Button("Delete Last"))
        {
            foreach(GameObject thing in lastSpawned)
            {
                GameObject.DestroyImmediate(thing, true);
            }

            lastSpawned.Clear();
        }

        //Button to delete all spawned objects
        if (GUILayout.Button("Delete All Objects"))
        {
            foreach (GameObject thing in allSpawned)
            {
                GameObject.DestroyImmediate(thing, true);
            }
            allSpawned.Clear();
        }

        EditorGUILayout.EndScrollView();
    }

    public void OnEnable()
    {
        string load = PlayerPrefs.GetString("Spawn");
        JsonUtility.FromJsonOverwrite(load, this);
    }

    public void OnDisable()
    {
        string save = JsonUtility.ToJson(this, true);
        PlayerPrefs.SetString("Spawn", save);
    }

}
