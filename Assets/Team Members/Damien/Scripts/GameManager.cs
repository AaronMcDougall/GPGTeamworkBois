using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;


namespace Damien
{
    public class GameManager : NetworkBehaviour
    {
        public event Action PlayMusic;
        public event Action TimerStart;
        public event Action TimerStop;
        public event Action TimerTick;

        public int maxTimer;
        public Platform platform;
        public int timerSeconds = 0;
        public int randomNumber;
        [FormerlySerializedAs("platforms")] public GameObject[] listOfPlatforms;
        public bool platformEnabled;


        public void PressedStart()
        {
            //randomNumber = Random.Range(0, listOfPlatforms.Length + 1);
            RoundStart();
        }


        public void RoundStart()
        {
            Instantiate(platform);
            PlayMusic?.Invoke();
            TimerStart?.Invoke();
        }

        public void PressedStop()
        {
            TimerStop?.Invoke();
        }

        public override void OnStartServer()
        {
            PressedStart(); //TODO: change to menu later
            TimerStart += RPCStartTimer;
            TimerStop += RPCStopTimer;
            TimerTick += RpcTimerCheck;
        }

        [ClientRpc]
        public void RPCStartTimer()
        {
            StartCoroutine(Timer());
        }

        [ClientRpc]

        public void RpcTimerCheck()
        {
            if (timerSeconds >= maxTimer)
            {
                EndRound();
            }
        }

        void EndRound()
        {
            RPCStopTimer();
            
        }

        [ClientRpc]
        public void RPCStopTimer()
        {
            StopCoroutine(Timer());
        }


        IEnumerator Timer()
        {
            yield return new WaitForSeconds(1f);
            timerSeconds++;
            TimerTick?.Invoke();
        }
    }
}