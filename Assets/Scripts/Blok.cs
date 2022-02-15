using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blok : MonoBehaviour

{

    [Header("Parametreler")]
    public bool isMayin = false;
    [Range(0f, 5f)] public float collisionKapatmaSuresi = 1f;


    [Header("Tanimlanacaklar")]
    public SpriteRenderer img;
    public Sprite[] sptKutular; //0. kutu, 1-8 sayı, 9 boş kutu , 10-11 bayraklar, 12 mayın
 public  CircleCollider2D myCollider2D;
   public int yanimdaKacMayinVar = 0;
    OyunKontrol oyunKontrol;
    bool tiklandi = false;
    bool oyunBasladi = false;
    bool dogruBayrakVar = false;
    Surat surat;

    Ses ses;



    // Start is called before the first frame update
    void Start()
    {
        Tanimlanacaklar();
    }

    private void Tanimlanacaklar()
    {
        ses = FindObjectOfType<Ses>();
        surat = FindObjectOfType<Surat>();
        myCollider2D = GetComponent<CircleCollider2D>();
        oyunKontrol = FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>();
        MayinYadaDegil();

    }


    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        
        if (oyunBasladi)
        {
            OyunBasladiktanSonraYapilacaklar();

        }
        else
        {

            OyunBaslamadanOnceYapilacaklar(otherCollider);
        }

    }

    private void OyunBasladiktanSonraYapilacaklar()
    {

        if (tiklandi) return;
        ResimAta();


    }

    private void OyunBaslamadanOnceYapilacaklar(Collider2D otherCollider)
    {
        if (isMayin) { return; }
        if (otherCollider.tag=="Mayin")
        {
            yanimdaKacMayinVar++;
            //img.sprite = sptKutular[yanimdaKacMayinVar];
        }


    }



    private void OyunuBitir()
    {
        img.sprite = sptKutular[12];
        img.color = new Color32(255, 0, 0, 255);
        oyunKontrol._btnBayrak.interactable = false;
        oyunKontrol.StopAllCoroutines();


        Blok[] bloklar = FindObjectsOfType<Blok>();
        foreach (Blok blok in bloklar)
        {
            blok.myCollider2D.enabled = false;

            if (blok.img.sprite.name== "OynFlag" )
            {
                if (!blok.isMayin)
                {
                    blok.img.sprite = sptKutular[11];
                }
            }
            else if (blok.yanimdaKacMayinVar>0&& blok.yanimdaKacMayinVar<9)
            {
                blok.img.sprite = sptKutular[blok.yanimdaKacMayinVar];
            }
            else if (blok.isMayin && !blok.tiklandi)
            {
                blok.img.sprite = sptKutular[12];
            }
        }
        oyunKontrol.Kaybettin();

    }



    private void MayinYadaDegil()
    {
        if (isMayin)
        {
            gameObject.tag = "Mayin";


        }
        else
        {
            gameObject.tag = "MayinDegil";
        }
    }

    private void OnMouseUp()
    {
        if (oyunKontrol.isPause) return;
        AlanKontrol();

    }

    public void AlanKontrol()
    {
        if (!oyunBasladi) { return; }
        if (!oyunKontrol.GetBayrakIsAktif())
        {

            oyunKontrol.ArttirHamleSayisi();
            if (img.sprite.name == "OynFlag")
            {
                return;
            }
            tiklandi = true;
            if (isMayin)
            {
                OyunuBitir();
                surat.SuratDegistir(2);
            }
            else
            {
                ResimAta();
                surat.SuratDegistir(0);
            }
        }
        else
        {
            oyunKontrol.ArttirHamleSayisi();
            if (img.sprite.name == "OynFlag")
            {

                img.sprite = sptKutular[0];
                oyunKontrol.BayrakKaldir();
                if (dogruBayrakVar)
                {
                    oyunKontrol.SetDogruBayrakSayisi("-");
                    dogruBayrakVar = false;
                }

                oyunKontrol.GuncelleUITxtBayrakSayisi();
            }
            else if (oyunKontrol.GetBayrakSayisi() > 0)
            {
                img.sprite = sptKutular[10];
                if (isMayin)
                {
                    oyunKontrol.SetDogruBayrakSayisi("+");
                    dogruBayrakVar = true;
                }
                oyunKontrol.BayrakKullan();
                oyunKontrol.GuncelleUITxtBayrakSayisi();
            }
            else
            {
                return;
            }
        }
    }

    private void OnMouseDown()
    {
        if(!oyunKontrol.GetBayrakIsAktif())
        surat.SuratDegistir(1);
    }
    

    private void ResimAta()
    {
        if (img.sprite.name == "OynFlag")        { return; }

        if (!ses.GetComponent<AudioSource>().isPlaying)
        {
            ses.PlayArama();
        }
            if (yanimdaKacMayinVar == 0)
        {
            img.sprite = sptKutular[9];
            myCollider2D.GetComponent<CircleCollider2D>().radius = 0.3f;
            
        }
        else
        {
            img.sprite = sptKutular[yanimdaKacMayinVar];
            
        }
        StartCoroutine(CollisionKapat());
    }
    public void SetOyunBasladi(bool deger)
    {
        oyunBasladi = deger;
    }


    IEnumerator CollisionKapat()
    {
        yield return new WaitForSeconds(collisionKapatmaSuresi);
        myCollider2D.enabled = false;
    }
}
