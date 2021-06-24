using System;
using Mirror;
using UnityEngine;

namespace John
{
    public class GameManager : NetworkBehaviour
    {
        public event Action StartMusic;
        
        public void Start()
        {
            if (isServer)
            {
                StartMusic += RPCPlayMusic;
                
            }
        }

        [ClientRpc]
        public void RPCPlayMusic()
        {
            Debug.Log("Play the music now");
        }
        
        
    }

}

