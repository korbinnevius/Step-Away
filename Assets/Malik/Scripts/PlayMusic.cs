using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayMusic : MonoBehaviour
{
public AudioClip[] _audioClip;
private AudioSource _audioSource;
public GameObject stopButton;





    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        stopButton = GetComponent<GameObject>();
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            Debug.Log("I have hit the Play Button");
            _audioSource.clip = PlayRandomMusic();
            _audioSource.Play();
           
           

        }
        if (stopButton.CompareTag("Hand"))
        {
            Debug.Log("I have hit the Stop Button");
            _audioSource.Stop();
           

        }
    }
    
    private AudioClip PlayRandomMusic()
    {

        return _audioClip[Random.Range(0, _audioClip.Length)];
    }

}
