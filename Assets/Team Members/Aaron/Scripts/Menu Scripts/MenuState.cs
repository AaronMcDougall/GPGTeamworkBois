using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Menu
{
    public class MenuState : MenuStateBase
    {
        public event Action OnMenu;
        public override void Enter()
        {
            base.Enter();
            OnMenu();
            //stop game input
            //start menu input
        }

        public override void Execute()
        {
            base.Execute();
        }

        public override void Exit()
        {
            base.Exit();
            //stop menu input
            //start game input
        }
    }
}