using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject explosion;
    public Vector3 ExplosionPoint;

    public event Action FadeExplosion;
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
        //look, a bit hacky/hardcoded
        ExplosionPoint = GetComponent<Impact>().ImpactPoint;
        Instantiate(explosion, ExplosionPoint, Quaternion.Euler(0, 0, 0));
        
        FadeExplosion?.Invoke();
    }
}