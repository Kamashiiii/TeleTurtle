using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SonsSlider2 : MonoBehaviour
{
    public AudioMixer audioMixer;


    
    public void SetVolumebg(float volume)
    {
        audioMixer.SetFloat("Volumebg", volume);
    }
}
