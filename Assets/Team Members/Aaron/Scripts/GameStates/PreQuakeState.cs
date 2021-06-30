using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aaron
{
  public class PreQuakeState : StateBase
  {
    public override void Enter()
    {
      base.Enter();

      Debug.Log("Pre Quake entered!");
    }

    public override void Execute()
    {
      base.Execute();

      Debug.Log("Pre Quake executed!");
    }

    public override void Exit()
    {
      base.Exit();

      Debug.Log("Pre Quake exited!");
    }

  }
}