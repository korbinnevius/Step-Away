using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RadioButtons : MonoBehaviour
{
    public UnityEvent buttonPress;
    public AudioClip[] _audioClip;
    private AudioSource _audioSource;
    // public AudioSource stopButton;
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            buttonPress.Invoke();
        }
    }

    public void PlayMusic()
    {
        Debug.Log("I have hit the Play Button");
        _audioSource.clip = PlayRandomMusic();
        _audioSource.Play();
    }

    // public void StopMusic()
    // {
    //     Debug.Log("I have hit the Stop Button");
    //     stopButton.Stop();
    // }
    public AudioClip PlayRandomMusic()
    {

        return _audioClip[Random.Range(0, _audioClip.Length)];
    }
}
