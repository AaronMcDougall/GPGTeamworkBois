using System.Collections;
using System.Collections.Generic;
using System;
using Damien;
using Mirror;
using UnityEngine;

public class Platform : NetworkBehaviour
{
    private int timer = 0;
    public int timeToMove = 60;
    public GameObject thisPlatform;
    public GameManager gameManager;

    void Awake()
    {
        if (isServer)
        {
            thisPlatform = gameObject;
            gameManager.TimerTick += RPCCountdown;
        }
    }

    [ClientRpc]
    void RPCCountdown()
    {
        timer++;
        if (timer >= timeToMove)
        {
            MovePlatform();
            gameManager.TimerTick -= RPCCountdown;
        }
    }

    void MovePlatform()
    {
        Debug.Log("Platform Moving");
    }
}