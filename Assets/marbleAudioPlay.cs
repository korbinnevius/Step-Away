using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marbleAudioPlay : MonoBehaviour
{
    private AudioSource _ar;
    [SerializeField] private AudioClip marbleAudio;
    [SerializeField] private int playAudio = 0;
    [SerializeField] private int stopAudio = 1;

    private void Awake()
    {
        _ar = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        MarbleAudioPlays();
    }
    
    public void MarbleAudioPlays()
    {
        if (playAudio < stopAudio)
        {
            playAudio = playAudio + 1;
            _ar.clip = marbleAudio;
            _ar.Play();
            
        }
    }
}
