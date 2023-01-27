using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControl : MonoBehaviour
{
  public GameObject LeftStick;
  public GameObject RightStick;
  public AudioSource Radio;

  float Vol => Vector3.Distance(LeftStick.transform.position, RightStick.transform.position);

  private void Awake()
  {
      Radio.volume = 0;
  }
  private void Update()
  {
      Radio.volume = Vol;
  }
}
