using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvaBolumSec : MonoBehaviour
{
    [SerializeField] Button _btnIptal;
    [SerializeField] Text _txtHeader;
    [SerializeField] GameObject _parentBolumler,_goUyariKutusu,_goSayfaKonum;
    ButtonLevel[] _btnsLevel;
    private void Awake()
    {
        double a = Convert.ToDouble(Screen.height) / Convert.ToDouble(Screen.width);
        if (1.5f > a) _goUyariKutusu.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        else _goUyariKutusu.transform.localScale = Vector3.one;

        _btnsLevel = _parentBolumler.GetComponentsInChildren<ButtonLevel>();
        _txtHeader.text = KAYIT.GetBolumler();
        _goSayfaKonum.transform.localPosition = new Vector3(0, KAYIT.GetSayfaKonum(), 0);
    }

    private void Start()
    {
        _btnIptal.onClick.AddListener(() => HandleIptal());
        AtaButtonlaraDeger(_btnsLevel);
    }

    private void HandleIptal()
    {
        SoundBox.instance.PlayOneShot(NamesOfSound.clickCikis);
        SetSayfaKonum();
        gameObject.SetActive(false);
    }
    public void SetSayfaKonum() { KAYIT.SetSayfaKonum(_goSayfaKonum.transform.position.y); }
    void AtaButtonlaraDeger(ButtonLevel[] buttonLevel)
    {
        for (int i = 0; i < buttonLevel.Length; i++)
        {

            buttonLevel[i].SetButton((KAYIT.GetSonAcikBolum() >= i + 1),
                    i + 1,
                     KAYIT.GetRekorYildiz(i + 1),
                     KAYIT.GetRekorSure(i + 1) == 10000 ? "00:00" : KAYIT.SureyiYaz(KAYIT.GetRekorSure(i + 1))
                       );

        }
    }
}
