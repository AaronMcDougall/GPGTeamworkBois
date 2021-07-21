using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perlinTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Perlin " + Mathf.PerlinNoise(Time.time, 0));
        Debug.Log("Random " + Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
