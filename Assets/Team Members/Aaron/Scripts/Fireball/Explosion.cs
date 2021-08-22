using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject explosion;
    public Vector3 ExplosionPoint;
    public int ShrinkTimer = 3;

    private void OnEnable()
    {
        FindObjectOfType<Impact>().OnImpact += CreateExplosion;
    }

    private void OnDisable()
    {
        FindObjectOfType<Impact>().OnImpact -= CreateExplosion;
    }

    public void CreateExplosion()
    {
        ExplosionPoint = this.transform.position;
        Debug.Log("Explosion now");
        Instantiate(explosion, ExplosionPoint, Quaternion.Euler(0, 0, 0));
        StartCoroutine (ExplosionShrinking());
    }

    IEnumerator ExplosionShrinking()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
            yield return new WaitForSeconds(1f);
        }
    }
}