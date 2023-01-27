using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;

    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform endPoint;

    [SerializeField] private float currentPosition;
    public AudioSource _audioSource;
    
    
    
    // Start is called before the first frame update
    void Start()
    {

         
        _audioSource = GetComponent<AudioSource>();
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            // Check to see if it has been saved or not. If it's not, give it a default value)
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeVolume()
    {
        currentPosition = Mathf.InverseLerp(startPoint.position.x, endPoint.position.x, transform.position.x);
         _audioSource.volume = currentPosition;
         Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
