using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DamageDealt : MonoBehaviour
{
    Rigidbody rb;

    public float damageDealt;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //Assuming our damage is dealt from getting physically hit by the other player/obstacle
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<Health>())
        {
            //is there a shorter way to write this to get the same reference?
            collision.gameObject.GetComponent<Health>().TakeDamage(damageDealt);
        }
    }
}
