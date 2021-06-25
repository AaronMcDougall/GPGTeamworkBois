using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FireBall
{
    public class NewBehaviourScript : StateBase
    {
        public override void Enter()
        {
            base.Enter();

            this.transform.localScale = new Vector3(2, 2, 2);
            //sound splat
            //change size
        }

        public override void Execute()
        {
            base.Execute();
            //impulse on collision
            //timer start?
        }

        public override void Exit()
        {
            base.Exit();

            //fade away
        }
    }
}
