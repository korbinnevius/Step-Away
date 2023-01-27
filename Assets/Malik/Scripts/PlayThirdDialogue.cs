using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayThirdDialogue : MonoBehaviour
{
    public AudioClip musicTooLoud;
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
            Debug.Log("Music is too loud");
            AudioPlays();


        }

    }

    public void AudioPlays()
    {
        if (playAudio < stopAudio)
        {
            playAudio = playAudio + 1;
            _audioSource.clip = musicTooLoud;
            _audioSource.Play();
            
        }
    }
}
