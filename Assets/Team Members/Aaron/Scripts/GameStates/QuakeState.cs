using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aaron
{
    public class QuakeState : StateBase
    {
        public override void Enter()
        {
            base.Enter();

            Debug.Log("Quaking entered!");
        }

        public override void Execute()
        {
            base.Execute();

            Debug.Log("Quaking Executed!");
        }

        public override void Exit()
        {
            base.Exit();

            Debug.Log("Quaking Exited!");
        }

    }
}