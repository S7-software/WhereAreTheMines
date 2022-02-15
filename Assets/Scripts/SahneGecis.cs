using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecis : MonoBehaviour
{
    
    public GameObject canvasUyariKutusu;
    float delay = 0.15f;
   
    public void AnsSayfayaGit()
    {
        SoundBox.instance.PlayOneShot(NamesOfSound.clickCikis);
        StartCoroutine(SahneDegistir(delay, "Ana Menu"));
    }

    public void OyunaBasla()
    {
        SoundBox.instance.PlayOneShot(NamesOfSound.clickGiris);
        StartCoroutine(SahneDegistir(delay, "Oyun"));

    }
    public void Oyna()
    {
        SoundBox.instance.PlayOneShot(NamesOfSound.clickGiris);

        canvasUyariKutusu.SetActive(true);
    }

    public void AyarlaraGit()
    {
        SoundBox.instance.PlayOneShot(NamesOfSound.clickGiris);
        StartCoroutine(SahneDegistir(delay, "Ayarar"));

    }
    public void NasilOynaniraGit()
    {
        SoundBox.instance.PlayOneShot(NamesOfSound.clickGiris);
        StartCoroutine(SahneDegistir(delay, "Nasil Oynanir"));
       
    }
    public void OyundanCik()
    {
        SoundBox.instance.PlayOneShot(NamesOfSound.clickCikis);
        Application.Quit();
    }


    IEnumerator SahneDegistir(float delay, string sahne)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sahne);
    }

}
