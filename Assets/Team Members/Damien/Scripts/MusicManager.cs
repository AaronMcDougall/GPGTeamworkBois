using System;
using System.Collections;
using Mirror;
using UnityEngine;

namespace Damien
{
    public class MusicManager : NetworkBehaviour
    {
        public GameManager gameManager;

        //public int timer = 120;

        public override void OnStartServer()
        {
            base.OnStartServer();
            if (isServer)
            {
                gameManager.PlayMusic += RPCStartMusic;
                //gameManager.TimerStart += RPCTimerGo;
                //gameManager.TimerStop += RPCTimerStop;
            }
        }

        public override void OnStopServer()
        {
            base.OnStopServer();
            gameManager.PlayMusic -= RPCStartMusic;
            //gameManager.TimerStart -= RPCTimerGo;
            //gameManager.TimerStop -= RPCTimerStop;
        }

        [ClientRpc]
        public void RPCStartMusic()
        {
            Debug.Log("The music started to play");
        }
    }
}

   

