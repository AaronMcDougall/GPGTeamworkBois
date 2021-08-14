using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    public float maxHealth;

    public event Action DeathEvent;

    //Standard Take Damage Function
    public void TakeDamage(float damage)
    {
        if (maxHealth <= 0)
        {
            CallDeathEvent();
        }
        else
        {
            maxHealth -= damage;
            Debug.Log("You took " + damage + "damage.");
        }
    }

    //Event for if death occurs, or should I have death in it's own area?
    public void CallDeathEvent()
    {
        //Stops health from going into the negatives for aesthetics
        maxHealth = 0;
        Debug.Log("You Died!");
        DeathEvent?.Invoke();
    }
}
