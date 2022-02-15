using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class OyunKontrol : MonoBehaviour
{

    private int _mayinSayisi = 0;
    private int _bayrakSayisi = 0;
    private int _dogruBayrakToplami = 0;
    private int _yapilanHamleSayisi = 0;
    private int _rekorSure;
    public bool oyunBasladi = false;
    public GameObject panelSonuc;
    public Button _btnTekrar, _btnBayrak, _btnAnaMenu, _btnSonraki, _btnAlanTara, _btnPause, _btnDevam;
    public GameObject panel, btnBasla;
    public Text txtSure;
    public Text txtMayin, txtBayrak, txtRekor;
    public GameObject arkaPlanGolge, _canvasDuraklatildi;
    Ses ses;
    int sure = 0;
    bool bayrakAktif = false;
    Blok[] bloklar;
    public bool isPause = true;
    int _bolum;
    int _countOfArama = 3;
    private void Awake()
    {

        double a = System.Convert.ToDouble(Screen.height) / System.Convert.ToDouble(Screen.width);
        if (1.5f > a)
        {
            Camera.main.transform.position = new Vector3(0, -0.39f, -10);
        }
        else
        {
            Camera.main.transform.position = new Vector3(0, 0, -10);
        }

        Esite();
        Tanimlamalar();


        MayinAta();

    }
    private void Start()
    {
        SayfaPause(true);
    }


    void SayfaPause(bool acik)
    {
        
        _btnAnaMenu.gameObject.SetActive(acik);
        _btnTekrar.gameObject.SetActive(acik);
        _btnSonraki.gameObject.SetActive(acik);
        _btnAlanTara.gameObject.SetActive(!acik);
        _btnPause.gameObject.SetActive(!acik);
        _btnBayrak.gameObject.SetActive(!acik);
    }
    private void Tanimlamalar()
    {
        bloklar = FindObjectsOfType<Blok>();
        _bayrakSayisi = _mayinSayisi;
        _bolum = _mayinSayisi - 9;
        txtBayrak.text = _bayrakSayisi.ToString();
        txtMayin.text = _mayinSayisi.ToString();
        txtSure.text = "00:00";
        panel.SetActive(true);
        ses = FindObjectOfType<Ses>();
        _btnSonraki.interactable = false;
        _btnAlanTara.onClick.AddListener(() => BulBosKutu());
        _btnPause.onClick.AddListener(() => HandlePause());
        _btnSonraki.onClick.AddListener(() => StartCoroutine(HandleSonraki()));
        _btnDevam.onClick.AddListener(() => HandleDevam());

    }

    private void HandleDevam()
    {
        SoundBox.instance.PlayOneShot(NamesOfSound.clickArama);
        SayfaPause(false);
        _canvasDuraklatildi.SetActive(false);
    }

    IEnumerator HandleSonraki()
    {
        SoundBox.instance.PlayOneShot(NamesOfSound.clickGiris);
        yield return new WaitForSeconds(0.2f);
        KAYIT.SetMayinSayisi(_mayinSayisi + 1);
        SceneManager.LoadScene("Oyun");
    }

    private void HandlePause()
    {
        _canvasDuraklatildi.SetActive(true);
        SayfaPause(true);
    }

    private void Esite()
    {
        _mayinSayisi = KAYIT.GetMayinSayisi();
        if (KAYIT.GetRekorSure(_bolum) != 10000)
        {
            int updtSure = KAYIT.GetRekorSure(_bolum);
            txtRekor.text = KAYIT.GetDilTexttOyunRekor() + KAYIT.SureyiYaz(updtSure);
        }
        else
        {
            txtRekor.text = KAYIT.GetDilTexttOyunRekor() + " --:--";
        }

    }

    IEnumerator SureyiCalistir()
    {
        while (oyunBasladi)
        {
            yield return new WaitForSeconds(1f);

            int mayinkontrol = 0;
            foreach (Blok blok in bloklar)
            {

                switch (blok.img.sprite.name)
                {
                    case "OynFlag":
                    case "OynKutu":
                        mayinkontrol++; break;

                    default:
                        break;
                }


            }
            if (mayinkontrol == _mayinSayisi)
            {
                Kazandin();
            }
            else
            {
                sure++;
                SureyiYaz(sure);
            }

        }

    }


    void BulBosKutu()
    {
        Blok[] bloklar = FindObjectsOfType<Blok>();
        bool yapildi = false;

        int random = Random.Range(0, bloklar.Length);

        int bulunacak = 0;
        while (!yapildi && bulunacak<9)
        {

            for (int i = random; i < bloklar.Length; i++)
            {
                if (bloklar[i].yanimdaKacMayinVar == bulunacak && !bloklar[i].isMayin && bloklar[i].myCollider2D.enabled)
                {

                    bloklar[i].AlanKontrol();
                    yapildi = true;
                    break;
                }
            }
            if (!yapildi)
            {
                for (int i = random-1; i >= 0; i--)
                {
                    if (bloklar[i].yanimdaKacMayinVar == bulunacak && !bloklar[i].isMayin && bloklar[i].myCollider2D.enabled)
                    {
                        bloklar[i].AlanKontrol();
                        yapildi = true;
                        break;
                    }
                }
            }
            bulunacak++;
        }

        _countOfArama--;


    }
    private void SureyiYaz(int sure)
    {
        string cahsTxtSure = "";
        if (sure >= 60)
        {
            int sureBolme = sure / 60;
            if (sureBolme >= 10)
            {
                cahsTxtSure = sureBolme.ToString();
            }
            else
            {
                cahsTxtSure = "0" + sureBolme.ToString();
            }
            cahsTxtSure += ":";
            sureBolme = sure % 60;
            if (sureBolme >= 10)
            {
                cahsTxtSure += sureBolme.ToString();
            }
            else
            {
                cahsTxtSure += "0" + sureBolme.ToString();
            }
        }
        else
        {
            if (sure >= 10)
            {
                cahsTxtSure = "00:" + sure;
            }
            else
            {
                cahsTxtSure = "00:0" + sure;
            }
        }
        txtSure.text = cahsTxtSure;
    }

    private void MayinAta()
    {

        int blokSayisi = bloklar.Length;

        List<int> blokIndex = new List<int>();
        int i = 0;
        while (blokSayisi > i)
        {
            blokIndex.Add(i);
            i++;
        }
        for (int j = 0; j < _mayinSayisi; j++)
        {
            int hangiRange = blokIndex[Random.Range(0, blokIndex.Count)];

            bloklar[hangiRange].GetComponent<Blok>().isMayin = true;

            blokIndex.Remove(hangiRange);
        }


    }




    public void BayrakKullan()
    {
        if (_bayrakSayisi == 0) { return; }
        _bayrakSayisi--;
        ses.PlayBayrakKoy();

    }

    public void BayrakKaldir()
    {
        _bayrakSayisi++;
        ses.PlayBayrakKaldir();
    }

    public void BaslaButton()
    {
        isPause = false;
        panel.SetActive(false);
        _btnBayrak.interactable = true;
        _btnTekrar.interactable = true;
        oyunBasladi = true;
        btnBasla.SetActive(false);
        arkaPlanGolge.SetActive(true);
        FindObjectOfType<Surat>().SuratDegistir(0);
        SayfaPause(false);
        StartCoroutine(SureyiCalistir());
        Blok[] bloklar = FindObjectsOfType<Blok>();
        foreach (Blok blok in bloklar)
        {
            blok.GetComponent<CircleCollider2D>().radius = 0.15f;
            blok.GetComponent<Blok>().SetOyunBasladi(true);
            oyunBasladi = true;

        }
    }

    public void SetBayrakAktif()
    {
        ColorBlock newColorBlock = _btnBayrak.colors;
        Color32[] newColor = { new Color32(255, 255, 0, 255), new Color32(255, 255, 255, 255) };
        if (!bayrakAktif)
        {
            bayrakAktif = true;


            newColorBlock.normalColor = newColor[0];
            newColorBlock.pressedColor = newColor[0];
            newColorBlock.selectedColor = newColor[0];
            _btnBayrak.colors = newColorBlock;
            ses.PlayClickGiris();
        }
        else
        {
            bayrakAktif = false;
            newColorBlock.normalColor = newColor[1];
            newColorBlock.pressedColor = newColor[1];
            newColorBlock.selectedColor = newColor[1];
            _btnBayrak.colors = newColorBlock;
            ses.PlayClickCikis();
        }


    }
    public bool GetBayrakIsAktif()
    {
        return bayrakAktif;
    }

    public int GetBayrakSayisi()
    {
        return _bayrakSayisi;
    }

    public void SetDogruBayrakSayisi(string isaret)
    {
        if (isaret == "+")
        {
            _dogruBayrakToplami++;
            if (_dogruBayrakToplami == _mayinSayisi)
            {
                Kazandin();
            }
        }
        else
        {
            _dogruBayrakToplami--;
        }
    }
    public void GuncelleUITxtBayrakSayisi()
    {
        if (_bayrakSayisi < 10)
        {
            txtBayrak.text = "00" + _bayrakSayisi;
        }
        else if (_bayrakSayisi < 100)
        {
            txtBayrak.text = "0" + _bayrakSayisi;
        }
        else
        {
            txtBayrak.text = "" + _bayrakSayisi;
        }
    }

    public void Kazandin()
    {
        ses.PlayKazanma();
        SayfaPause(true);
        _btnSonraki.interactable = true;

        StopAllCoroutines();
        int yildizSayisi = _countOfArama<2?1:_countOfArama;
        KAYIT.SetRekorYildiz(_bolum, yildizSayisi);
        KAYIT.SetSonAcikBolumArti(_bolum + 1);


        Blok[] bloklar = FindObjectsOfType<Blok>();
        foreach (Blok blok in bloklar)
        {
            blok.GetComponent<CircleCollider2D>().enabled = false;

        }
        panelSonuc.SetActive(true);
        Sonuc sonuc = panelSonuc.GetComponent<Sonuc>();
        sonuc.SetTxtHamle(_yapilanHamleSayisi.ToString());
        sonuc.SetTxtMayin(_mayinSayisi.ToString());
        sonuc.SetTxtSure(txtSure.text);
        sonuc.SetTxtSonuc(KAYIT.GetDilTexttOyunOyunSonuKazandin());
        sonuc.SetYildiz(yildizSayisi);



        if (sure < KAYIT.GetRekorSure(_bolum))
        {
            sonuc.SetTxtMesaj(KAYIT.GetDilTexttOyunOyunSonuKazandinRekor());
            KAYIT.SetRekor(_bolum, sure);
        }
        else
        {
            sonuc.SetTxtMesaj(KAYIT.GetDilTexttOyunOyunSonuKazandinNormal());
        }
        _btnBayrak.interactable = false;

    }

    public void ArttirHamleSayisi()
    {
        _yapilanHamleSayisi++;
    }

    public void Kaybettin()
    {
        ses.PlayPatlama();
        SayfaPause(true);
        _btnSonraki.interactable = false;
        StartCoroutine(KacSayiBeklesin(0.7f));


    }
    IEnumerator KacSayiBeklesin(float sure)
    {
        yield return new WaitForSeconds(sure);
        panelSonuc.SetActive(true);
        Sonuc sonuc = panelSonuc.GetComponent<Sonuc>();
        sonuc.SetTxtHamle(_yapilanHamleSayisi.ToString());
        sonuc.SetTxtMayin(_mayinSayisi.ToString());
        sonuc.SetTxtSure(txtSure.text);
        sonuc.SetTxtSonuc(KAYIT.GetDilTexttOyunOyunSonuKaybettin());

        sonuc.SetTxtMesaj(KAYIT.GetDilTexttOyunOyunSonuKaybettinMesaj());
        sonuc.SetYildiz(0);
    }
}
