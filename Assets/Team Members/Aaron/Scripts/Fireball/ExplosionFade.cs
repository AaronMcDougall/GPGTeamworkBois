using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionFade : MonoBehaviour
{
    public float shrinkTimer;
    private void OnEnable()
    {
        FindObjectOfType<Explosion>().FadeExplosion += Shrinkage;
    }

    private void OnDisable()
    {
        FindObjectOfType<Explosion>().FadeExplosion -= Shrinkage;
    }

    void Shrinkage()
    {
        StartCoroutine(ExplosionShrinking());
    }
    
    IEnumerator ExplosionShrinking()
        {
            for(int i = 0; i < shrinkTimer; i++)
            {
                Debug.Log("Shrinking");
                Debug.Log(i);
                yield return new WaitForSeconds(1);
            }
            Debug.Log("Dunzo");
            
            Destroy(this.gameObject);
        }
}
