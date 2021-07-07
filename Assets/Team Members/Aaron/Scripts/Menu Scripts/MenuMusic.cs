using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menu
{
    public class MenuMusic : MonoBehaviour
    {
        public AudioSource music;

        public void OnEnable()
        {
            FindObjectOfType<EscapeEventManager>().RunEscape += RunMusic;
        }


        public void RunMusic()
        {
            music.Play();
        }

    }
}
