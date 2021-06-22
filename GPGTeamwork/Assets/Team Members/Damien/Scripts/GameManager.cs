using System;
using Mirror;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public event Action StartEvent;

    public void PressedStart()
    {
        StartEvent?.Invoke();
        
    }
}
