using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.CompareTag("Radio"))
    //     {
    //         Debug.Log("I have the cube in hand");
    //     
    //     
    //     }
    // }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("I collided with an appropiate object");
    }
}
