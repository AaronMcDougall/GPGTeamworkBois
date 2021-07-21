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
        public Platform platform;
        public int timerSeconds = 0;
        public int randomNumber;
        [FormerlySerializedAs("platforms")] public GameObject[] listOfPlatforms;
        public bool platformEnabled;


        public void PressedStart()
        {
            randomNumber = Random.Range(0, listOfPlatforms.Length + 1);
            PlayMusic?.Invoke();
            TimerStart?.Invoke();
            RoundStart();
        }


        public void RoundStart()
        {
            foreach (GameObject platform in listOfPlatforms)
            {
                //see if there is a platform already on the map
                if (!platformEnabled)
                {
                    {
                        Instantiate(listOfPlatforms[randomNumber]);
                        platformEnabled = true;
                    }
                }
            }
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
        }

        [ClientRpc]
        public void RPCStartTimer()
        {
            StartCoroutine(Timer());
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