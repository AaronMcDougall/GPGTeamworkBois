using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Menu
{
    public class EscapeEventManager : MonoBehaviour
    {
        public event Action RunEscape;

        public void RunEscapeMenu()
        {
            RunEscape();
        }
    }
}
