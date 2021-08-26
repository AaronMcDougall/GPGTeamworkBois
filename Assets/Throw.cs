using Mirror;
using UnityEngine;

public class Throw : NetworkBehaviour
{
   public GameObject throwPoint;
   public GameObject throwPrefab;
   public float speed;
   
   public override void OnStartAuthority()
   {
      base.OnStartAuthority();
      enabled = true;
   }
   private void Update()
   {
      if (Input.GetButtonDown("Fire1"))
      {
         GameObject throwable = Instantiate(throwPrefab, throwPoint.transform.position, throwPoint.transform.rotation);
         NetworkServer.Spawn(throwable);
         var newrb = throwable.GetComponent<Rigidbody>();
         
         newrb.AddForce(transform.forward * speed);
         
      }
   }
}
