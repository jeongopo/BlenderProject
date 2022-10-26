using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SEManager : MonoBehaviour
{
    public AudioSource SE_audioSource;
    public AudioClip[] SE_ChatClip;
    enum clip
    {
        CHAT,
    }

    public void changeAudioClip(AudioClip ac)
    {
        SE_audioSource.clip = ac;
    }

    public void playAudioClip()
    {
        SE_audioSource.PlayOneShot(SE_audioSource.clip);
    }

    public void playAudioClip(AudioClip ac)
    {
        SE_audioSource.clip = ac;
        SE_audioSource.PlayOneShot(ac);
    }

    public void playChatCilp()
    { 
        /*
        SE_audioSource.Stop();
        SE_audioSource.clip = SE_ChatClip[Random.Range(0,2)];
        SE_audioSource.Play();
        */
    }

    public void stopAllAudioClip()
    {
        SE_audioSource.Stop();
    }
}