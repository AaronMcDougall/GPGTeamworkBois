using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

namespace John
{
    public class Pendulum : NetworkBehaviour
    {
        public float speed = 1;
        public float xAngleRotation = 60;
      
    
        public void FixedUpdate () 
        {
            float rotateX = Mathf.SmoothStep(xAngleRotation,-xAngleRotation,Mathf.PingPong(Time.time * speed,1));
            transform.rotation = Quaternion.Euler(rotateX,0,0);
            
        }
    
    
    }
}

