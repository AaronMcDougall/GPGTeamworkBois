using System;
using Mirror;
using UnityEngine;

namespace John
{
    public class GameManager : NetworkBehaviour
    {
        public event Action StartMusic;
        public event Action StartTimer;

        public event Action TimerEnd;
       
        public void PlayMusic()
        {
            StartMusic?.Invoke();
        }
        
        public void PlayTimer()
        {
            StartTimer?.Invoke();
        }

        public void RoundOver()
        {
            TimerEnd?.Invoke();
        }

        
        
        
    }

}

