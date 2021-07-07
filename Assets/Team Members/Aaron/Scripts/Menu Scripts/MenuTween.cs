using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using MiscUtil.Xml.Linq.Extensions;

public class MenuTween : MonoBehaviour
{
    public float alphaTargetLevel;
    public float text;
    public float duration;

    // Start is called before the first frame update
    void Start()
    {
        //DOTween.ToAlpha(Getter, Setter, alphaTargetLevel, duration);
        GetComponent<CanvasGroup>().DOFade(alphaTargetLevel, duration);
    }

    private float Getter()
    {
        return text;
    }

    private void Setter()
    {

    }


    
    public void OnEnable()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        duration -= Time.deltaTime;
    }

    


}
