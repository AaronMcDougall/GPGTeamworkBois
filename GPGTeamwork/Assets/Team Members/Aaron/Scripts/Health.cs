using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    public event Action DamageTaken;
    public float healthRemaining;
    public float damageTaken;

    // Start is called before the first frame update
    void Start()
    {
        //subscribes and activates when GetHit is fired off
        FindObjectOfType<playerScript>().GetHit += TakeDamage;

        //Gets the current health value
        GetComponent<Health>().healthRemaining = healthRemaining;
    }

    public void TakeDamage()
    {
        //subtracts the damage dealt by the attacker
        healthRemaining -= damageTaken;
        //fires off the damage taken event for anybody listening IE death script, wounded animation/sound effects etc
        DamageTaken();
    }
}
