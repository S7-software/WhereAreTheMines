using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DilAyarlaOyun : MonoBehaviour
{

    public Text txtMayin, txtSure, txtHamle, txtBtnBasla;
    
    void Start()
    {
        txtHamle.text = KAYIT.GetDilTexttOyunOyunSonuHamle();
        txtSure.text = KAYIT.GetDilTexttOyunOyunSonuSure();
txtMayin.text= KAYIT.GetDilTexttOyunOyunSonuMayin();
        txtBtnBasla.text =$" {OyunKontrol.instance._bolum} \n- " + KAYIT.GetDilButtontOyunBasla()+" -";
    }

   
}
