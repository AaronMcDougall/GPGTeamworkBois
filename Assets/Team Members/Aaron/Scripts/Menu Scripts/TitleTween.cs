using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using DG.Tweening;
using MiscUtil.Xml.Linq.Extensions;

public class TitleTween : MonoBehaviour
{
    public float tweakLevel;
    public float target;
    public float duration;

    public event Action yerp;

    // Start is called before the first frame update
    void Start()
    {
        DOTween.To(Getter, Setter, target, duration).SetEase(Ease.OutBounce).OnComplete(Finish);
    }

    // Update is called once per frame
    void Update()
    {
        duration -= Time.deltaTime;
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
        yerp();
    }
}
