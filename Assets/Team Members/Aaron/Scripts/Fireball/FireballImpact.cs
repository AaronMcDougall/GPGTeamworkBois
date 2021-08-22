using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballImpact : MonoBehaviour
{
    private void OnEnable()
    {
        FindObjectOfType<Impact>().OnImpact += DestroyFireball;
    }

    private void OnDisable()
    {
        FindObjectOfType<Impact>().OnImpact -= DestroyFireball;
    }

    void DestroyFireball()
    {
        Destroy(this.gameObject);
    }
}
