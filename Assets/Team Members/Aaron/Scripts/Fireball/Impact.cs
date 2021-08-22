using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Impact : MonoBehaviour
{
    public event Action OnImpact;

    public Vector3 ImpactPoint;
    
    public void OnCollisionEnter(Collision other)
    {
        ImpactPoint = this.transform.position;
        OnImpact?.Invoke();
        Debug.Log("Impact Coords are " + ImpactPoint);
    }
}
