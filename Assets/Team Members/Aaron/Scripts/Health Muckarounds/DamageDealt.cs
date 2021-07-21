using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DamageDealt : MonoBehaviour
{

    public event Action TakeDamageEvent;
    Rigidbody rb;

    public float damageDealt;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealDamage()
    {
        /*if(gameObject.GetComponent<Health>())
        {
            GetComponent<Health>().TakeDamage(DamageDealt);
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Health>())
        {
            GetComponent<Health>().TakeDamage(damageDealt);
        }
    }

}
