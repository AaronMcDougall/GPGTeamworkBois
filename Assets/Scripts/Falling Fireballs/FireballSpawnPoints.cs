using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Fireball
{ public class FireballSpawnPoints : MonoBehaviour
    {
        public GameObject objectToSpawn;
        public int amountToSpawn;
        public float spawnDelay;

        public float xSpawnMin;
        public float xSpawnMax;
        public float zSpawnMin;
        public float zSpawnMax;
        public float ySpawn;


        IEnumerator SpawnItem()
        {
            for (int i = 0; i < amountToSpawn; i++)
            {
                Instantiate(objectToSpawn,
                    new Vector3(Random.Range(xSpawnMin, xSpawnMax), ySpawn, Random.Range(zSpawnMin, zSpawnMax)),
                    Quaternion.Euler(0, 0, 0));

                yield return new WaitForSeconds(spawnDelay);
            }
        }

    }
}