using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class playerScript : MonoBehaviour
{
    public event Action GetHitEvent;


    public void Attack()
    {
        //Might be character specific animations and sounds popping off when they get hit?
        GetHitEvent?.Invoke();                      
    }
}