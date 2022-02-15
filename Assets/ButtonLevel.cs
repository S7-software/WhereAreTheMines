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
    Color renkBeyazSeffaf = new Color(255, 255, 255, 0.12f);
    Color renkBeyaz = new Color(255, 255, 255, 255);
    Color renkSiyahSeffaf = new Color(0, 0, 0, 0.30f);
    Color renkSiyaf = new Color(0, 0, 0, 255);

    [SerializeField] Color renkKirmizi, renkMavi, renkYesil;

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

        switch (kacYildiz)
        {
            case 1: _txtSure.color = renkKirmizi; break;
            case 2: _txtSure.color = renkMavi; break;
            case 3: _txtSure.color = renkYesil; break;
            default:
                _txtSure.color =  renkSiyahSeffaf;
                break;
        }
       
        _txtLevel.color = aktif ? renkSiyaf : renkSiyahSeffaf;
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
        _yildizlar[0].color = sayi >= 1 ? renkBeyaz : renkBeyazSeffaf;
        _yildizlar[1].color = sayi >= 2 ? renkBeyaz : renkBeyazSeffaf;
        _yildizlar[2].color = sayi >= 3 ? renkBeyaz : renkBeyazSeffaf;
    }
}
