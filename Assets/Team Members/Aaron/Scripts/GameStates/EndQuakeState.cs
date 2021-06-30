using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aaron
{
  public class EndQuakeState : StateBase
    {
      public override void Enter()
      {
        base.Enter();

        Debug.Log("Quake ending entered!");
      }

      public override void Execute()
      {
        base.Execute();

        Debug.Log("Quake Ending executed!");
      }

      public override void Exit()
      {
        base.Exit();

        Debug.Log("Quake Ending exited!");
      }

    }

}
