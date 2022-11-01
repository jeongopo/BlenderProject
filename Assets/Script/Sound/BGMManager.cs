using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMManager : MonoBehaviour
{
    public AudioSource BGM_audioSource;
    public AudioClip[] BGM_ChatClip;

    public float BgmVolume = 1.0f;
    public Slider BgmVolumeSlider;
    bool BgmMute = false;

    public void SetBgmMute()
    {
        BgmMute = !BgmMute;
        BGM_audioSource.mute = BgmMute;
    }

    public void SetBgmVolume()
    {
        BgmVolume = BgmVolumeSlider.value;
        BGM_audioSource.volume = BgmVolume;
    }
}
