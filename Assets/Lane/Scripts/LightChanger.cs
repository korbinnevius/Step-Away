using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChanger : MonoBehaviour
{
    public Material EffectedMaterial;
    public Light thisone;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        thisone.color = EffectedMaterial.color;
    }
}
