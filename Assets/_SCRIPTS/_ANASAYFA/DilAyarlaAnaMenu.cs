﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DilAyarlaAnaMenu : MonoBehaviour
{

    public Text txtBtnOyna, txtBtnAyarlar, txtBtnCikis;
    // public Text txtMayinSayisi, txtBtnBasla, txtBtnIptal;
    void Start()
    {
        DilleriAyarla();
    }

    private void DilleriAyarla()
    {
        txtBtnOyna.text = KAYIT.GetDilButtonAnaMenuOyna();
        txtBtnAyarlar.text = KAYIT.GetDilButtonAnaMenuAyarlar();
        txtBtnCikis.text = KAYIT.GetDilButtonAnaMenuCikis();

        //txtMayinSayisi.text = KAYIT.GetDilTextUyariKutusuMayinSayisi();
        //txtBtnBasla.text = KAYIT.GetDilButtonUyariKutusuBasla();
        //txtBtnIptal.text = KAYIT.GetDilButtonUyariKutusuIptal();

    }

}
