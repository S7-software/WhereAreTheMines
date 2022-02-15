using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonLevel : MonoBehaviour
{

    [SerializeField] Text _txtLevel, _txtSure;

    [SerializeField] Image[] _yildizlar;
    Button _myBtn;
    Color renk = new Color(255, 255, 255, 0.30f);
    Color renkTxt = new Color(0, 0, 0, 0.30f);
    Color renkOrj = new Color(255, 255, 255, 255);
    Color renkOrjTxt = new Color(0, 0, 0, 255);
    private void Awake()
    {
        _myBtn = GetComponent<Button>();

    }


    public void SetButton(bool aktif, int kacinciLevel, int kacYildiz, string rekorSure)
    {
        _myBtn.interactable = aktif;
        KacYildiz(kacYildiz);

        _txtLevel.text = kacinciLevel.ToString();
        _txtSure.text = rekorSure;

        _txtSure.color = aktif ? _txtSure.color : renkTxt;
        _txtLevel.color = aktif ? renkOrjTxt : renkTxt;
        _myBtn.onClick.AddListener(()=>StartCoroutine(HandleBolumeGit(kacinciLevel)));


    }

   IEnumerator HandleBolumeGit(int bolum)
    {
        KAYIT.SetMayinSayisi(bolum + 9);
        SoundBox.instance.PlayOneShot(NamesOfSound.clickGiris);
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Oyun"); ;

    }

    void KacYildiz(int sayi)
    {
        _yildizlar[0].color = sayi >= 1 ? renkOrj : renk;
        _yildizlar[1].color = sayi >= 2 ? renkOrj : renk;
        _yildizlar[2].color = sayi >= 3 ? renkOrj : renk;
    }
}
