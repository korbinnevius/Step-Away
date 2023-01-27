using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleSpawnWin : MonoBehaviour
{

    [SerializeField] private GameObject marble;
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider other)
    {
        marble.SetActive(true);
    }
}
