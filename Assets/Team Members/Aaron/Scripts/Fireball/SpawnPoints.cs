using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fireball
{ public class SpawnPoints : MonoBehaviour
    {
        public float spawnX;
        public float spawnY;
        public float spawnZ;

        private void Start()
        {
            getSpawnX();
            getSpawnY();
            getSpawnZ();
        }

        public void getSpawnX()
        {
            spawnX = this.transform.position.x;
        }
        
        public void getSpawnY()
        {
            spawnY = this.transform.position.y;
        }

        public void getSpawnZ()
        {
            spawnZ = this.transform.position.z;
        }

        public void GetSpawns()
        {
            getSpawnX();
            getSpawnY();
            getSpawnZ();
        }
    }
}