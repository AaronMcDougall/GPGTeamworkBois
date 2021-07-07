using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using DG.Tweening;
using MiscUtil.Xml.Linq.Extensions;

namespace Menu
{
    public class TitleTween : MonoBehaviour
    {
        public float tweakLevel;
        public float target;
        public float duration;

        public AudioSource MenuTrack;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        public void OnEnable()
        {
            FindObjectOfType<EscapeEventManager>().RunEscape += TitleDrop;
        }

        public void TitleDrop()
        {
            DOTween.To(Getter, Setter, target, duration).SetEase(Ease.OutBounce).OnComplete(Finish);
            MenuTrack.Play();
        }


    void Update()
        {
            //duration -= Time.deltaTime;
        }

        private float Getter()
        {
            return tweakLevel;
        }

        private void Setter(float pnewvalue)
        {
            tweakLevel = pnewvalue;
            transform.localPosition = new Vector3(0f, tweakLevel, 0f);
        }

        private void Finish()
        {

        }
    }
}
