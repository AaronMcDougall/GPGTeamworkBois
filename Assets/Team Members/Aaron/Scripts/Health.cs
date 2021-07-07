using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    public float maxHealth;

    public event Action DeathEvent;    

    public void TakeDamage(float damageTaken)
    {
        if (maxHealth <= 0)
        {
            CallDeathEvent();
        }
        else
        {
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

    private void OnEnable()
    {
 
    }
}
