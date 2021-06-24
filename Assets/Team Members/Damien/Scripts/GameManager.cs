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

        public int timerSeconds = 0;
    
        public void PressedStart()
        {
            PlayMusic?.Invoke();
            TimerStart?.Invoke();
        
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
        }
    
    }

}
