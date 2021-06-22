using System;
using Mirror;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public event Action PlayMusic;
    public event Action TimerStart;
    
    public void PressedStart()
    {
        PlayMusic?.Invoke();
        TimerStart?.Invoke();
    }

    
}
