using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAction : MonoBehaviour
{
    private InteractiveDissolveShader[] _dissolvers;
    [SerializeField] private BoxCollider mainCubeCaseBC;

    [SerializeField] private GameObject techPuzzleBox;
    
    // Start is called before the first frame update
    void Awake()
    {
        _dissolvers = GetComponentsInChildren<InteractiveDissolveShader>();
        Debug.Log(_dissolvers.Length);
    }
    private void OnTriggerEnter(Collider other)
    {
        DissolveCube();
        mainCubeCaseBC.enabled = false;
        techPuzzleBox.SetActive(true);
    }

    public void DissolveCube()
    {
        foreach (var dissolver in _dissolvers)
        {
            dissolver.StartDissolve();
        }
        
    }
    
}
