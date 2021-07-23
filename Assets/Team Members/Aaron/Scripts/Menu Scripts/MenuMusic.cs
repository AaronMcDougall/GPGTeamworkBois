using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menu
{
    public class MenuMusic : MonoBehaviour
    {
        public AudioSource music;
        public AudioSource exit;

        public void OnEnable()
        {
            FindObjectOfType<EscapeEventManager>().RunEscape += RunMusic;
            FindObjectOfType<EscapeEventManager>().RunReturn += StopMusic;
        }

        public void RunMusic()
        {
            music.Play();
        }

        public void StopMusic()
        {
            music.Stop();
            exit.Play();
        }
        
    }
}
