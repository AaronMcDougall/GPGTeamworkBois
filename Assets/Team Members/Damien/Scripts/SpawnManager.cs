using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

namespace Damien
{
    public class SpawnManager : NetworkBehaviour
    {
        public GameObject playerObject;
        public List<Transform> spawnPoints;

        // Start is called before the first frame update
        void OnStartServer()
        {
            if (isServer)
            {
                
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
