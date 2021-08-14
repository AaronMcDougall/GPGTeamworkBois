using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpawn : MonoBehaviour
{
    public GameObject fireball;

    public Vector3 spawnPoint;
    
    
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = this.transform.position;
        CreateFireball();
    }

    public void CreateFireball()
    {
        Instantiate(fireball, spawnPoint, Quaternion.Euler(0, 0, 0));
    }
}
