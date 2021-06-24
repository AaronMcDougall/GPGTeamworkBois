using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using Mirror.Examples.RigidbodyPhysics;
using UnityEngine;

namespace John
{
    public class Rock : NetworkBehaviour
    {
        public float speed;
        private Rigidbody rb;
        private float bulletTimer;
   

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            bulletTimer = 15;
        }

        private void FixedUpdate()
        {
            rb.velocity = new Vector3(0, 0, speed);
            bulletTimer--;
            if (bulletTimer <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}

