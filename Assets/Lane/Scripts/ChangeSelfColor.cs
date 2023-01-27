using System;
using UnityEngine;

namespace Lane.Scripts
{
    public class ChangeSelfColor : MonoBehaviour
    {
        private MeshRenderer _meshRenderer;

        public Transform colorWheel;
        public bool UpdateInUpdate;
        private void Awake()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        private void OnEnable()
        {
            UpdateColor();
        }

        private void Update()
        {
            if (UpdateInUpdate)
            {
                UpdateColor();
            }
        }
        public void UpdateColor()
        { 
            _meshRenderer.material.color = HSV.GetColorWheelColor(colorWheel,HSV.GetPositionOnColorWheel(colorWheel,transform.position),1);

        }
    }
}