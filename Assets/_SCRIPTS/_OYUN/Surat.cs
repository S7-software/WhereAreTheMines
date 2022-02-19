using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Surat : MonoBehaviour
{
    [Header("Tanımlamalar")]
    public SpriteRenderer surat;
    public Sprite[] sptSuratlar;

    void Start()
    {
        surat.sprite = sptSuratlar[0];
    }

    public void SuratDegistir(int hangiSurat)
    {
        if (hangiSurat < 0 && hangiSurat > 2) { return; }
        surat.sprite = sptSuratlar[hangiSurat];
    }
}
