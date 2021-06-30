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
        }
    }

    public void CallDeathEvent()
    {
        DeathEvent?.Invoke();
        Debug.Log("Y'all are dead.");
    }
}
