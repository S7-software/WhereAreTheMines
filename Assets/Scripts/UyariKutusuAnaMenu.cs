using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UyariKutusuAnaMenu : MonoBehaviour
{

    [Header("Tanimlanacaklar")]
    public Text txtMayinSayisi;
    public Slider sliderMayin;
    public Button btnBasla, btnIptal;
    public GameObject CanvasUyariKutusu;
    int xcMayinSayisi;
    Ses ses;

    // Start is called before the first frame update
    void Start()
    {

        Tanimlamalar();
        ButtonlaraAtamalar();
    }

    private void ButtonlaraAtamalar()
    {
        btnIptal.onClick.AddListener(UyariKutusunuKapat);
        btnBasla.onClick.AddListener(OyunaGit);
    }

    private void Tanimlamalar()
    {
        ses = FindObjectOfType<Ses>();


        sliderMayin.value = KAYIT.GetMayinSayisi();
        txtMayinSayisi.text = sliderMayin.value.ToString();

        xcMayinSayisi = Convert.ToInt32(sliderMayin.value);
    }

    // Update is called once per frame


    public void SliderDegerGuncelleme()
    {

        int xcSliderValue = Convert.ToInt32(sliderMayin.value);
        txtMayinSayisi.text = sliderMayin.value.ToString();
        if (xcSliderValue < 45)
        {
            txtMayinSayisi.color = Color.green;
        }
        else if (xcSliderValue > 44 && xcSliderValue < 100)
        {
            txtMayinSayisi.color = Color.yellow;
        }
        else
        {
            txtMayinSayisi.color = Color.red;
        }

        if (xcMayinSayisi > xcSliderValue)
        {
            if (!ses.GetComponent<AudioSource>().isPlaying)
                ses.PlayClickGiris();
        }
        else
        {
            if (!ses.GetComponent<AudioSource>().isPlaying)
                ses.PlayClickCikis();
        }
    }

    void UyariKutusunuKapat()
    {
        CanvasUyariKutusu.SetActive(false);
        ses.PlayClickCikis();
    }

    public void OyunaGit()
    {
        ses.PlayClickGiris();
        KAYIT.SetMayinSayisi(Convert.ToInt32(sliderMayin.value));
        SceneManager.LoadScene("Oyun");
    }
}
