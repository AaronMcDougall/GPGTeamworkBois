using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using MiscUtil.Xml.Linq.Extensions;

namespace Menu
{
    public class MenuTween : MonoBehaviour
    {
        public float alphaTargetLevel;
        public float duration;
        public float textAlpha;

        public CanvasGroup menu;

        // Start is called before the first frame update
        void Start()
        {
            menu.alpha = 0;            
        }

        public void OnEnable()
        {
            FindObjectOfType<EscapeEventManager>().RunEscape += MenuAppear;
        }

        public void MenuAppear()
        {
            DOTween.To(Getter, Setter, alphaTargetLevel, duration);
        }
        private float Getter()
        {
            return textAlpha;
        }

        private void Setter(float newAlpha)
        {
            textAlpha = newAlpha;

            GetComponent<CanvasGroup>().alpha = textAlpha;
        }

        // Update is called once per frame
        void Update()
        {
            //duration -= Time.deltaTime;
        }




    }
}

