using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class RockWall : MonoBehaviour
{
    public GameObject rockPrefab;
    public Transform shootingPoint;
    private Vector3 positionVariance;
    public float shootDelay;
    public float bulletSpeed;

    private void Start()
    {
        bulletSpeed = rockPrefab.GetComponent<Rock>().speed;
    }

    public void StartShoot()
    {
        StartCoroutine(ShootRock());
    }
    void FixedUpdate()
    {
        positionVariance = new Vector3(Random.Range(-transform.localScale.x/2,transform.localScale.x/2), Random.Range(-transform.localScale.y/2,transform.localScale.y/2),-1);
        shootDelay = Random.Range(0.5f, 1.3f);
    }

    IEnumerator ShootRock()
    {
        for (;;)
        {
            shootingPoint.position = new Vector3((transform.position.x + positionVariance.x),(transform.position.y + positionVariance.y), (transform.position.z + -positionVariance.z));
            Instantiate(rockPrefab, shootingPoint.position, Quaternion.identity);
            
            yield return new WaitForSeconds(shootDelay); 
        }
        
    }
}
