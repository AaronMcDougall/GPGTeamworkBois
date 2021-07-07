using System;
using System.Collections;
using Mirror;
using UnityEngine;



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
        public GameObject[] platforms;
        public bool platformEnabled;
        

        public void PressedStart()
        {
            PlayMusic?.Invoke();
            TimerStart?.Invoke();
            RoundStart();
        }

       

        public void RoundStart()
        {
            foreach(GameObject platform in platforms)
            {
                //see if there is a platform already on the map
                if (!platformEnabled)
                {
                    //see if the platform currently selected has been spawned recently
                    //if (!Platform)
                    {
                        gameObject.SetActive(true);
                        platformEnabled = true;
                        
                    }
                    
                }
            }
        }

        public void PressedStop()
        {
            TimerStop?.Invoke();
        }

        public void Start()
        {
            if (isServer)
            {
                TimerStart += RPCStartTimer;
                TimerStop += RPCStopTimer;
            }
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