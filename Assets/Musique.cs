using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musique : MonoBehaviour
{
    Object.DontDestroyOnLoad

    public AudioSource sourceAudio;

    [SerializeField] AudioClip musiqueDeFond;
    // Start is called before the first frame update
    void Start()
    {
        sourceAudio = GetComponent<AudioSource>();
        sourceAudio.clip = musiqueDeFond;
        sourceAudio.Play();          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
