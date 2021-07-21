using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public ThingsToSave saveStuff;

    public void SaveVariables()
    {
        string save = JsonUtility.ToJson(saveStuff, true);
        PlayerPrefs.SetString("Settings", save);
    }

    public void LoadVariables()
    {
        string load = PlayerPrefs.GetString("Settings");
        JsonUtility.FromJsonOverwrite(load, saveStuff);
    }
}
