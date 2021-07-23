using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Menu
{
    public class EscapeEventManager : MonoBehaviour
    {
        public event Action RunEscape;
        public event Action RunReturn;

        public void RunEscapeMenu()
        {
            RunEscape();
        }

        public void RunReturnEvent()
        {
            RunReturn();
        }
    }
}
