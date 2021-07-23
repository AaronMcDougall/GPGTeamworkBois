using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Menu
{
    public class MenuState : MenuStateBase
    {
        //public event Action OnMenu;
        public override void Enter()
        {
            base.Enter();
            Debug.Log("Menu State");
        }

        public override void Execute()
        {
            base.Execute();
        }

        public override void Exit()
        {
            base.Exit();
        }
    }
}