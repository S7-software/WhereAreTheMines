using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DilAyarlaOyun : MonoBehaviour
{

    public Text txtMayin, txtSure, txtHamle, txtBtnBasla;
    
    // Start is called before the first frame update
    void Start()
    {
        txtHamle.text = KAYIT.GetDilTexttOyunOyunSonuHamle();
        txtSure.text = KAYIT.GetDilTexttOyunOyunSonuSure();
txtMayin.text= KAYIT.GetDilTexttOyunOyunSonuMayin();
        txtBtnBasla.text = KAYIT.GetDilButtontOyunBasla();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
