using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public static Clock instance;
    public float _gecenSure = 0;

    public bool _basla = false;
    public bool _durakla = false;
    private void Awake()
    {
        instance = this;

    }

    private void Update()
    {
        if (!_basla) return;
        if (_durakla) return;
        _gecenSure += Time.deltaTime;

        OyunKontrol.instance.SureyiYaz(((int)_gecenSure));
    }


}
