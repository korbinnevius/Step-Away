using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveDissolveShader : MonoBehaviour
{

    private Material _material;
    public Vector3 startDis;
    public Vector3 endDis;
    public float dissolveTime;
    
    //[SerializeField] private BoxCollider mainCubeCasePushBC;

    private void Awake()
    {
        _material = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if (Input.GetMouseButton(0))
    //     {
    //         CastClickRay();
    //     }
    //
    //     if (Input.GetKeyDown(KeyCode.A))
    //     {
    //         StartDissolve(transform.position);
    //     }
    // }

   

    // private void CastClickRay()
    // {
    //     var camera = Camera.main;
    //     var mousePosition = Input.mousePosition;
    //     var ray = camera.ScreenPointToRay(new Vector3(mousePosition.x, mousePosition.y, camera.nearClipPlane));
    //     if (Physics.Raycast(ray, out var hit) && hit.collider.gameObject == gameObject)
    //     {
    //         StartDissolve(hit.point);
    //     }
    // }

    public void StartDissolve()
    {
        //_material.SetVector("_DissolveCenter", center);
        
        Debug.Log("Start dissolve");
        StartCoroutine(DissolvingLerp(startDis, endDis, dissolveTime));
        //mainCubeCasePushBC.enabled = false;
        
        
    }

    IEnumerator DissolvingLerp(Vector3 start, Vector3 end, float dissolveTime)
    {
        float t = -1.1f;
        while (t < 1.1)
        {
            
            t = t + Time.deltaTime / dissolveTime;
            _material.SetFloat("_ShaderDissolveTime", t);
            yield return null;
        }
        
    }
}
