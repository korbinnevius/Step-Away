using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic : MonoBehaviour
{
    public AudioSource stopButton;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            PleaseStopMusic();
        }
    }
    

    public void PleaseStopMusic()
    {
        Debug.Log("I have hit the Stop Button");
        stopButton.Stop();
    }
   
}

