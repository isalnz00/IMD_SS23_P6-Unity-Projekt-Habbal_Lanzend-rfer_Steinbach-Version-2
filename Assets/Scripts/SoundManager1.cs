using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager1 : MonoBehaviour
{
    public AudioClip audioRaeder, audioKopf1, audioKopf2, audioArme, audioErsatz;
    public AudioSource src;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void playAudioKopf1()
    {
        src.clip = audioKopf1;
        src.Play();
    }
    public void playAudioKopf2()
    {
        src.clip = audioKopf2;
        src.Play();
    }
    public void playAudioArme()
    {
        src.clip = audioArme;
        src.Play();
    }
    public void playAudioRaeder()
    {
        src.clip = audioRaeder;
        src.Play();
    }

     public void playAudioErsatz()
    {
        src.clip = audioErsatz;
        src.Play();
    }
}
