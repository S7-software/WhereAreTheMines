using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecis : MonoBehaviour
{
    Ses ses;
    public GameObject canvasUyariKutusu;

     void Start()
    {
        ses = FindObjectOfType<Ses>();
    }
    public void AnsSayfayaGit()
    {
        ses.PlayClickCikis();
        SceneManager.LoadScene("Ana Menu");
    }
    
    public void OyunaBasla()
    {
        ses.PlayClickGiris();
        SceneManager.LoadScene("Oyun");
    }
    public void Oyna()
    {
        canvasUyariKutusu.SetActive(true);
    }

    public void AyarlaraGit()
    {
        ses.PlayClickGiris();
        SceneManager.LoadScene("Ayarar");
    }
    public void NasilOynaniraGit()
    {
        ses.PlayClickGiris();
        SceneManager.LoadScene("Nasil Oynanir");
    }
    public void OyundanCik()
    {
        ses.PlayClickCikis();
        Application.Quit();
    }




}
