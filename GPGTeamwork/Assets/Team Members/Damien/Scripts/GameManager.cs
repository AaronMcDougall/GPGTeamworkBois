using System;
using Mirror;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public event Action PlayMusic;
    public event Action TimerStart;
    public event Action TimerStop;
    
    public void PressedStart()
    {
        PlayMusic?.Invoke();
        TimerStart?.Invoke();
        
    }

    public void PressedStop()
    {
        TimerStop?.Invoke();
    }

    
}
