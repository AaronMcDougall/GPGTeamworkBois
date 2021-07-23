using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    public float maxHealth;
    public float eventDamage;

    public event Action DeathEvent;

    public void Start()
    {
        FindObjectOfType<DamageEvent>().EventDamage += TakeEventDamage;
    }

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

    //Takes damage when damage event is called. Could easily call from DamageDealt.cs if wanting to keep all damage consistent?
    public void TakeEventDamage()
    {
        if (maxHealth <= 0)
        {
            CallDeathEvent();
        }
        else
        {
            eventDamage = FindObjectOfType<DamageEvent>().eventDamageDealt;
            maxHealth -= eventDamage;
            Debug.Log("Taking Damage From Event");
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
