using System;
using Mirror;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public event Action StartMusic;

    public GameManager gameManager;


    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnEnable()
    {
        gameManager.StartEvent += PlayMusic;
    }

    private void OnDisable()
    {
        gameManager.StartEvent -= PlayMusic;
    }

    
    public void PlayMusic()
    {
        Debug.Log("The music started to play");
    }
}
