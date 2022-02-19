using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ses : MonoBehaviour    
{
    public AudioClip[] myAudioClips;

    AudioSource myAudioSource;
    // Start is called before the first frame update
    void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
        myAudioSource.volume = KAYIT.GetSes();
    }

   
    public void PlayClickGiris()
    {
        myAudioSource.clip = myAudioClips[0];
        myAudioSource.Play();
    }
    public void PlayClickCikis()
    {
        myAudioSource.clip = myAudioClips[1];
        myAudioSource.Play();
    }
    public void PlayPatlama()
    {
        myAudioSource.clip = myAudioClips[2];
        myAudioSource.Play();
    }
    public void PlayKazanma()
    {
        myAudioSource.clip = myAudioClips[3];
        myAudioSource.Play();
    }

    public void PlayArama()
    {
        myAudioSource.clip = myAudioClips[4];
        myAudioSource.Play();
    }
    public void PlayBayrakKoy()
    {
        myAudioSource.clip = myAudioClips[5];
        myAudioSource.Play();
    }
    public void PlayBayrakKaldir()
    {
        myAudioSource.clip = myAudioClips[6];
        myAudioSource.Play();
    }
}
