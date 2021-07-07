using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    public float maxHealth;

    public float damageTaken;
    public event Action TakeDamageEvent;
    public event Action DeathEvent;

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Lava")
        {
            damageTaken = 200;
            TakeDamage();
        }    
    }

    public void TakeDamage()
    {
        if (maxHealth <= 0)
        {
            CallDeathEvent();
        }
        else
        {
            TakeDamageEvent?.Invoke();
            maxHealth -= damageTaken;
            Debug.Log("Y'all got hurt.");
            CallDeathEvent();
        }
    }

    public void CallDeathEvent()
    {
        if(maxHealth <= 0)
        {
            DeathEvent?.Invoke();
            Debug.Log("Y'all are dead.");
        }
        
    }
}
