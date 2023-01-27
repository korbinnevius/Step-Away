using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{

    private Animator _animator;
    [SerializeField] private string triggerName;
    
    
    // Start is called before the first frame update
    private void Awake()
    {
        _animator = GetComponentInParent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //to do check that hand is overlapping
        _animator.SetTrigger(triggerName);
        
    }
}
