using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SEManager : MonoBehaviour
{
    public AudioSource SE_audioSource;
    public AudioClip[] SE_ChatClip;

    public float SEVolume = 1.0f;
    public Slider SEVolumeSlider;
    bool SEMute = false;
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


    public void SetSEMute()
    {
        SEMute = !SEMute;
        SE_audioSource.mute = SEMute;
    }

    public void SetSEVolume()
    {
        SEVolume = SEVolumeSlider.value;
        SE_audioSource.volume = SEVolume;
    }

}