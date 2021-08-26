using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class Knockback : NetworkBehaviour
{
   public int knockbackPower;
   public float radius;

   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Player"))
      {
         Vector3 direction = (transform.position - other.transform.position).normalized;

         other.GetComponent<Rigidbody>().AddExplosionForce(knockbackPower,direction, radius);
      }
   }
}
