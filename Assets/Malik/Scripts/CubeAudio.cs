using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAudio : MonoBehaviour

{
    public AudioClip cubeContact;
    private AudioSource _audioSource;
    [SerializeField] private int playAudio = 0;
    [SerializeField] private int stopAudio = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            Debug.Log("I have the cube in hand");
            AudioPlays();


        }

    }

    // private void OnCollisionEnter(Collision other)
    // {
    //     if (other.gameObject.CompareTag("Cube"))
    //     {
    //         Debug.Log("I have the cube in hand");
    //         PlayDialogue();
    //     
    //     
    //     }
    // }

    public void AudioPlays()
    {
        if (playAudio < stopAudio)
        {
            playAudio = playAudio + 1;
            _audioSource.clip = cubeContact;
            _audioSource.Play();
            
        }
    }
}
