using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    public float speed = 1;
    public float xAngleRotation = 60;
       
    void Update () 
    {
            float rotateX = Mathf.SmoothStep(xAngleRotation,-xAngleRotation,Mathf.PingPong(Time.time * speed,1));
            transform.rotation = Quaternion.Euler(rotateX,0,0);
    }
}
