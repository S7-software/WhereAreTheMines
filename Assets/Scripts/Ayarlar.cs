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
    GameObject go;
    bool ilkAcilis = true;
    private void Awake()
    {
      double a=Convert.ToDouble(Screen.height)/ Convert.ToDouble(Screen.width) ;
        if (1.5f > a) gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        else gameObject.transform.localScale = Vector3.one;
    }
    private void Start()
    {


        Tanimlanacaklar();
    }

    public void ChangeSlider()
    {
        float xcSes = KAYIT.GetSes();
        KAYIT.SetSes(mySlider.value);
        SoundBox.instance.SetVolume(KAYIT.GetSes());
        if (ilkAcilis)
        {
            ilkAcilis = false;
            return;
        }
        if (xcSes > KAYIT.GetSes())
        {
            SoundBox.instance.PlayIfDontPlay(NamesOfSound.clickCikis);
            //if(!ses.GetComponent<AudioSource>().isPlaying)
            //ses.PlayClickCikis();
        }
        else
        {
            SoundBox.instance.PlayIfDontPlay(NamesOfSound.clickGiris);
            //if (!ses.GetComponent<AudioSource>().isPlaying)
            //    ses.PlayClickGiris();
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
                SoundBox.instance.PlayOneShot(NamesOfSound.clickGiris); break;
            case "jp":

                KAYIT.SetDil("jp");
                SoundBox.instance.PlayOneShot(NamesOfSound.clickGiris); break;
            case "fr":

                KAYIT.SetDil("fr");
                SoundBox.instance.PlayOneShot(NamesOfSound.clickGiris); break;
            case "es":

                KAYIT.SetDil("es");
                SoundBox.instance.PlayOneShot(NamesOfSound.clickGiris); break;
            case "ru":

                KAYIT.SetDil("ru");
                SoundBox.instance.PlayOneShot(NamesOfSound.clickGiris); break;
            case "de":

                KAYIT.SetDil("de");
                SoundBox.instance.PlayOneShot(NamesOfSound.clickGiris); break;
            default:

                KAYIT.SetDil("en");
                SoundBox.instance.PlayOneShot(NamesOfSound.clickGiris); break;
        }


        StartCoroutine(SahneDegistir(0.2f, "Ayarar"));
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

    IEnumerator SahneDegistir(float delay, string sahne)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sahne);
    }
    public void ButunKayitleriSil()
    {
        SoundBox.instance.PlayOneShot(NamesOfSound.clickCikis);
        KAYIT.ButuKayitlariSil();
        StartCoroutine(SahneDegistir(0.5f, "Intro"));
    }


}
