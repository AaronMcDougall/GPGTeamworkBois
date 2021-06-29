using System;
using System.Collections;
using Mirror;
using UnityEngine;
using Mirror;

namespace John
{
    public class MusicManager : NetworkBehaviour
    {
        public GameManager gameManager;
        public AudioSource audioSource;
       
        public override void OnStartServer()
        {
            base.OnStartServer();
            
            
            if (isServer)
            {
                gameManager.StartMusic += RPCPlayTunes;
                
            }
        }

        public override void OnStopServer()
        {
            base.OnStopServer();
            gameManager.StartMusic -= RPCPlayTunes;
        }
        
        [ClientRpc]
        void RPCPlayTunes()
        {
            audioSource.Play();
            Debug.Log("Music is Playing");
        }
        
        
        [Command(requiresAuthority = false)]
        void CmdPlayTunes()
        {
            RPCPlayTunes();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                CmdPlayTunes();
            }
        }
    }

}

    

