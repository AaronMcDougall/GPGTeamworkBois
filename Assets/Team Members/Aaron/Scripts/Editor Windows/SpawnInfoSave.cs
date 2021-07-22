using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInfoSave : MonoBehaviour
{
    public TaskWindow spawnSave;

    public void SaveSpawnInfo()
    {
        string save = JsonUtility.ToJson(spawnSave, true);
        PlayerPrefs.SetString("Spawn", save);
    }

    public void LoadSpawnInfo()
    {
        string load = PlayerPrefs.GetString("Spawn");
        JsonUtility.FromJsonOverwrite(load, spawnSave);
    }

}
