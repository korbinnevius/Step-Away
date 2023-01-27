using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBrushAudio : MonoBehaviour
{
    public AudioClip _paintBrush;
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
            Debug.Log("I got the paint brush in hand");
            AudioPlays();


        }

    }
    public void AudioPlays()
    {
        if (playAudio < stopAudio)
        {
            playAudio = playAudio + 1;
            _audioSource.clip = _paintBrush;
            _audioSource.Play();
            
        }
    }
    
}
