using System;
using Mirror;
using UnityEngine;

namespace John
{
    public class GameManager : NetworkBehaviour
    {
        public event Action StartMusic;
        public event Action StartTimer;
       
        public void PlayMusic()
        {
            StartMusic?.Invoke();
        }
        
        public void PlayTimer()
        {
            StartTimer?.Invoke();
        }

        
        
        
    }

}

