using System;
using System.Collections;
using Mirror;
using UnityEngine;

namespace John
{
    public class MusicManager : NetworkBehaviour
    {
        public GameManager gameManager;
        public AudioSource audioSource;

        //Client action occurs to trigger server 
        private void Update()
        {
            Client();
        }

        void Client()
        {
           if (Input.GetKeyDown(KeyCode.Space))
           {
               CmdPlayTunes();
           } 
        }
        
        //Server send the message to all clients to do the thing
        [Command(requiresAuthority = false)]
        void CmdPlayTunes()
        {
            RPCPlayTunes();
        }

        // The thing happens
        [ClientRpc]
        void RPCPlayTunes()
        {
            audioSource.Play();
            Debug.Log("Time to Escape From The City!");
        }



    }

}

    

