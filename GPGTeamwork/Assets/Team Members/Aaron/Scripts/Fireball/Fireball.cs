using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed;

    void Start()
    {
        //set direction
        //set speed
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision other)
    {
        this.transform.localScale = new Vector3(2, 2, 2);
    }
}
