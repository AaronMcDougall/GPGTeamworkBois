using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.GetComponent<FPSPlayerController>())
        {
            Debug.Log("Player Died");
        }
    }
}
