using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fireball
{
    public class Fireball : MonoBehaviour
    {
        public Vector3 spawnPoint;
        public GameObject fireballPrefab;
        

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void FireballSpawn()
        {
            Instantiate(fireballPrefab, spawnPoint, Quaternion.Euler(0,0,0));
        }
    }
}
