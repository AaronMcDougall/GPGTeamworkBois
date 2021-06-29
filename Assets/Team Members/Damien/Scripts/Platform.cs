using System.Collections;
using System.Collections.Generic;
using System;
using Damien;
using Mirror;
using UnityEngine;

public class Platform : NetworkBehaviour
{
    public GameObject thisPlatform;
    public GameManager gameManager;

    void Awake()
    {
        if (isServer)
        {
            thisPlatform = gameObject;
            gameManager.TimerStart += RPCCountdown;
        }
    }

    [ClientRpc]
    void RPCCountdown()
    {
        
    }
}