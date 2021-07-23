using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DamageEvent : MonoBehaviour
{
    public event Action EventDamage;
    public float eventDamageDealt;

    public void Start()
    {
        eventDamageDealt = FindObjectOfType<DamageDealt>().damageDealt;
    }

    public void CallDamageEvent()
    {
        EventDamage?.Invoke();
        Debug.Log("Damage Event has been called");
    }
}
