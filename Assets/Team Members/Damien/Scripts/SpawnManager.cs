using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class SpawnManager : NetworkBehaviour
{
    public GameObject playerObject;
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
