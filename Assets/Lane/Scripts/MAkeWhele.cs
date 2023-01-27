using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAkeWhele : MonoBehaviour
{
    public GameObject Circle;
    public int numberOfObjects = 20;
    public float radius = 5f;
    private Vector3 scaleChange;
    
    void Start()
    {
        scaleChange = new Vector3(0.9f, 0f, 0.9f);
        Circle.transform.localScale -= scaleChange;
        for (int i = 0; i < numberOfObjects; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfObjects;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            Vector3 pos = transform.position + new Vector3(x, 0, z);
            float angleDegrees = -angle * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
            Instantiate(Circle, pos, rot);

        }
    }
}
    
    
    
    
