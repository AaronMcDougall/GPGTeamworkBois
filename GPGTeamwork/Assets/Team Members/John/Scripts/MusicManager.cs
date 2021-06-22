using System;
using System.Collections;
using Mirror;
using UnityEngine;

public class MusicManager : NetworkBehaviour
{
   public GameManager gameManager;

   public int timer = 120;

   public override void OnStartServer()
   {
       base.OnStartServer();
       if (isServer)
       {
           gameManager.PlayMusic += RPCStartMusic;
           gameManager.TimerStart += RPCTimerGo;
       }
   }
   public override void OnStopServer()
   {
       base.OnStopServer();
       gameManager.PlayMusic -= RPCStartMusic;
       gameManager.TimerStart -= RPCTimerGo;
   }
    [ClientRpc]
    public void RPCStartMusic()
    {
        Debug.Log("The music started to play");
    }
    [ClientRpc]
    public void RPCTimerGo()
    {
        StartCoroutine(Timer());
    }

    [ClientRpc]
    public void RPCTimerStop()
    {
        StopCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        for (;;)
        {
            timer--;
            Debug.Log("The timer is at " + timer);
            yield return new WaitForSeconds(1f);
        }
    }
}
