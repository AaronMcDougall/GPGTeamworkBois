using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FireBall
{
    public class FireballState : StateBase
    {
        public GameObject FireballPrefab;
        public override void Enter()
        {
            base.Enter();

            GameObject.Instantiate(FireballPrefab, new Vector3 (0, 0, 0), Quaternion.Euler(1, 1, 1));
            //sound blast
            //spawn prefab
        }

        public override void Execute()
        {
            base.Execute();

            //sound flying
        }

        public override void Exit()
        {
            base.Exit();
        }
    }
}
