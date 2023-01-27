using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
 public Material Changer;
 public GameObject HomeBase;
 public GameObject RedTab;
 public GameObject BlueTab;
 public GameObject GreenTab;
 float Red =>  Vector3.Distance(RedTab.transform.position, HomeBase.transform.position);
 float Blue => Vector3.Distance(BlueTab.transform.position, HomeBase.transform.position);
 float Green =>  Vector3.Distance(GreenTab.transform.position, HomeBase.transform.position);
 private void Update()
 {
  if (Red > Blue)
  {
   Changer.color = new Color(Red, 0, 0);
  }
  else if (Red > Green)
  {
   Changer.color = new Color(Red, 0, 0);
  }
  else if (Blue > Red)
  {
   Changer.color = new Color(0, 0, Blue);
  }
  else if (Blue > Green)
  {
   Changer.color = new Color(0, 0, Blue);
  }
  else if (Green > Red)
  {
   Changer.color = new Color(0, Green, 0);
  }
  if (Green > Blue)
  {
   Changer.color = new Color(0, Green, 0);
  }
  
 }
}
