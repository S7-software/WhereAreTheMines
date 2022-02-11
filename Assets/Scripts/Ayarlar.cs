using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ayarlar : MonoBehaviour
{
    public Button btnDemo;
    public Button[] btnDiller;
    public Slider mySlider;

    bool ilkAcilis = true;
    public Ses ses;
    private void Start()
    {
        
        
        Tanimlanacaklar();
    }

    public void ChangeSlider()
    {
        float xcSes = KAYIT.GetSes();
        KAYIT.SetSes(mySlider.value);
        ses.GetComponent<AudioSource>().volume = KAYIT.GetSes();
        if (ilkAcilis)
        {
            ilkAcilis = false;
            return;
        }
        if (xcSes>KAYIT.GetSes())
        {
            if(!ses.GetComponent<AudioSource>().isPlaying)
            ses.PlayClickCikis();
        }
        else 
        {
            if (!ses.GetComponent<AudioSource>().isPlaying)
                ses.PlayClickGiris();
        }
    }
    
    private void Tanimlanacaklar()
    {
        
        mySlider.value = KAYIT.GetSes();

        DilButtonlaririninRekleriniAyarla(KAYIT.GetSistemDili());
        
    }

    public void DiliAyarla(string hangiDil)
    {

        switch (hangiDil)
        {
            case "tr":
                
                KAYIT.SetDil("tr");
                ses.PlayClickGiris();
                break;
            case "jp":
                
                KAYIT.SetDil("jp");
                ses.PlayClickGiris();
                break;
            case "fr":
                
                KAYIT.SetDil("fr");
                ses.PlayClickGiris();
                break;
            case "es":
                
                KAYIT.SetDil("es");
                ses.PlayClickGiris();
                break;
            case "ru":
                
                KAYIT.SetDil("ru");
                ses.PlayClickGiris();
                break;
            case "de":
                
                KAYIT.SetDil("de");
                ses.PlayClickGiris();
                break;
            default:
                
                KAYIT.SetDil("en");
                ses.PlayClickGiris();
                break;
        }

        SceneManager.LoadScene("Ayarar");
    }


    void DilButtonlaririninRekleriniAyarla(string dil)
    {
        string xcDil;
        switch (dil)
        {
            case "tr": xcDil = "BtnTurkce"; break;
            case "en": xcDil = "BtnEnglish"; break;
            case "es": xcDil = "BtnIspanyolca"; break;
            case "de": xcDil = "BtnAlmanca"; break;
            case "fr": xcDil = "BtnFransizca"; break;
            case "ru": xcDil = "BtnRusca"; break;
            case "jp": xcDil = "BtnJaponca"; break;
           

            default:
                xcDil = "BtnEnglish";
                break;
        }
        foreach (Button btnDil in btnDiller)
        {
           
            btnDil.interactable = true;

            if (btnDil.name == xcDil)
            {
                btnDil.interactable = false;

            }
        }
    }


    public void ButunKayitleriSil()
    {
        ses.PlayClickCikis();
        KAYIT.ButuKayitlariSil();
        SceneManager.LoadScene("Intro");
    }

    
}
