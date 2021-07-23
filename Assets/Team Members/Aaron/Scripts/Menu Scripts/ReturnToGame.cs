using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menu
{
    public class ReturnToGame : MonoBehaviour
    {
        public Canvas menuCanvas;

        private void OnEnable()
        {
            FindObjectOfType<EscapeEventManager>().RunReturn += CloseCanvas;
        }

        private void CloseCanvas()
        {
            menuCanvas.enabled = false;
        }
    }
}
