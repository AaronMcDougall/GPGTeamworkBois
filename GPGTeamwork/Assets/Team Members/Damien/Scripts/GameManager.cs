using System;
using System.Collections.Generic;
using Mirror;
using UnityEngine;
using Random = UnityEngine.Random;


public class GameManager : MonoBehaviour
{
    public event Action StartEvent;
    public GameObject[] platforms;


    private void Start()
    {
        
    }

    private void Awake()
    {
        foreach (GameObject platform in platforms)
        {
            enabled = false;
        }
    }

    public void PressedStart()
    {
        StartEvent?.Invoke();
        EnablePlatform();
    }

    void EnablePlatform()
    {
        int rand = Random.Range(0, platforms.Length + 1);
    }
}
