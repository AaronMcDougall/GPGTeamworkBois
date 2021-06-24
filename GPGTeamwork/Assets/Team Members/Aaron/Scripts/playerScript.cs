using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class playerScript : MonoBehaviour
{
    public float damage = 20;
    public event Action GetHit;

    void Start()
    {
        //Do I not want this in here? Does it make the scripts too dependant on one another?
        //Or should offensive stats have their own script in a larger project?
        GetComponent<Health>().damageTaken = damage;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("p"))
        {
            Attack();
        }
    }

    public void Attack()
    {
        //Might be character specific animations and sounds popping off when they attack?
        if (GetHit != null)
        {
            GetHit();                      
        }
    }
}

