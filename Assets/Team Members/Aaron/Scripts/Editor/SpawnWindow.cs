using System.Collections;
using System.Collections.Generic;
using Epic.OnlineServices.Connect;
using UnityEngine;
using UnityEditor;

public class SpawnWindow : EditorWindow
{
    public GameObject itemToSpawn;
    public int amountToSpawn;
    public float spawnDelay;

    //X Spawn Variables
    public float xSpawnMin;
    public float xSpawnMinLimit;
    public float xSpawnMax;
    public float xSpawnMaxLimit;

    //Z Spawn Variables
    public float zSpawnMin;
    public float zSpawnMinLimit;
    public float zSpawnMax;
    public float zSpawnMaxLimit;

    //Y Spawn Variable
    public int ySpawn;


    //Scroll Variable
    public Vector2 scrollPos;


    //Creates Window

    [MenuItem("Custom Windows/Spawn Window")]
    static void Init()
    {
        SpawnWindow window = (SpawnWindow) EditorWindow.GetWindow(typeof(SpawnWindow));
        window.Show();
    }

    void OnGUI()
    {
        scrollPos = EditorGUILayout.BeginScrollView(scrollPos);

        //GameObject code
        GUILayout.Label("Item to Spawn", EditorStyles.boldLabel);
        itemToSpawn =
            (GameObject) EditorGUILayout.ObjectField("Object to Spawn", itemToSpawn, typeof(GameObject), false);
        amountToSpawn = EditorGUILayout.IntField("Amount to Spawn", amountToSpawn);
        spawnDelay = EditorGUILayout.FloatField("Spawn Frequency", spawnDelay);

        //X location code
        GUILayout.Label("Spawn Location Range", EditorStyles.boldLabel);
        GUILayout.BeginHorizontal();
        xSpawnMin = EditorGUILayout.FloatField("X Minimum", xSpawnMin);
        xSpawnMax = EditorGUILayout.FloatField("X Maximum", xSpawnMax);
        GUILayout.EndHorizontal();
        /*GUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Minimum X Value", xSpawnMin.ToString());
        EditorGUILayout.LabelField("Maximum X Value", xSpawnMax.ToString());
        GUILayout.EndHorizontal();
        EditorGUILayout.MinMaxSlider(ref xSpawnMin, ref xSpawnMax, xSpawnMinLimit, xSpawnMaxLimit);*/

        //Z location code
        GUILayout.BeginHorizontal();
        zSpawnMin = EditorGUILayout.FloatField("Z Minimum", zSpawnMin);
        zSpawnMax = EditorGUILayout.FloatField("Z Maximum", zSpawnMax);
        GUILayout.EndHorizontal();
        /*GUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Minimum Z Value", zSpawnMin.ToString());
        EditorGUILayout.LabelField("Maximum Z Value", zSpawnMax.ToString());
        GUILayout.EndHorizontal();
        EditorGUILayout.MinMaxSlider(ref zSpawnMin, ref zSpawnMax, zSpawnMinLimit, zSpawnMaxLimit);*/

        //Y location code
        ySpawn = EditorGUILayout.IntField("Height", ySpawn);


        GUILayout.Label("Spawn Item", EditorStyles.boldLabel);
        //spawn button
        if (GUILayout.Button("Spawn Objects"))
        {
            if (amountToSpawn > 0)
            {
                for (int i = 0; i < amountToSpawn; i++)
                {
                    if (Time.deltaTime > spawnDelay)
                    {
                        GameObject copy = Instantiate(itemToSpawn,
                            new Vector3((Random.Range(xSpawnMin, xSpawnMax)), ySpawn,
                                Random.Range(zSpawnMin, zSpawnMax)),
                            Quaternion.Euler(0, 0, 0));
                    }
                }
            }
        }

        EditorGUILayout.EndScrollView();
    }
}