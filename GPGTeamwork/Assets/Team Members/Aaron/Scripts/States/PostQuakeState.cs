using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aaron
{
    public class PostQuakeState : StateBase
    {

        public override void Enter()
        {
            base.Enter();

            Debug.Log("Post Quake Entered");
        }

        public override void Execute()
        {
            base.Execute();

            Debug.Log("Post Quake Executed");
        }

        public override void Exit()
        {
            base.Exit();

            Debug.Log("Post Quake Exited");
        }


    }
}
