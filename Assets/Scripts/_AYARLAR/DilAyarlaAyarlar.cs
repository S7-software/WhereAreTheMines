using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DilAyarlaAyarlar : MonoBehaviour
{

    public Text txtHeader, txtSes, txtDil, txtRekorlariSifirla, txtBtnSifirla, txtBtnHakkimizda, txtBtnAnaMenu, txtHeader2;
    void Start()
    {
        txtHeader.text = KAYIT.GetDilAyarlarHeader();
        txtHeader2.text = KAYIT.GetDilAyarlarHeader();
        txtSes.text = KAYIT.GetDilTextAyarlarSes();
        txtDil.text = KAYIT.GetDilTextAyarlarDil();
        txtRekorlariSifirla.text = KAYIT.GetDilTextAyarlarRekorlariSifirla();
        txtBtnSifirla.text = KAYIT.GetDilButtontAyarlarSifirla();
        txtBtnHakkimizda.text = KAYIT.GetDilButtontAyarlarHakkimizda();
        txtBtnAnaMenu.text = KAYIT.GetDilButtontAyarlarAnaMenu();
    }

    
}
