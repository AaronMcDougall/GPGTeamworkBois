using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject explosion;

    public Vector3 explosionPoint;

    public Animation shrinkage;

    private void OnCollisionEnter(Collision other)
    {
        Destroy(this.gameObject);
        explosionPoint = this.transform.position;
        OnImpact();
    }

    public void OnImpact()
    {
        Instantiate(explosion, explosionPoint, Quaternion.Euler(0, 0, 0));
    }

}