using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class HSV : MonoBehaviour
{ 
    public Material Changer;
    public GameObject HomeBase;
    public GameObject UpVib;
    public GameObject DownVib;
    public GameObject LowSat;
    public GameObject HighSat;
    public Transform ColorWheelOrigin;
    private float Sat;
    private float Hue;
    private float Vib;

    //float Hue => 
    private float PSat => Vector3.Distance(HighSat.transform.position, HomeBase.transform.position);
    private float LSat => -(Vector3.Distance(LowSat.transform.position, HomeBase.transform.position));
    private float PVib => Vector3.Distance(UpVib.transform.position, HomeBase.transform.position);
    private float LVib => -(Vector3.Distance(DownVib.transform.position, HomeBase.transform.position));
    

    // Update is called once per frame
    void Update()
    {
        if (PSat>LSat)
        { 
            Sat = PSat;
        }
        else if (LSat > PSat)
        {
            Sat = LSat;
        }

        if (PVib > LVib)
        { Vib = PVib;
        }
        else if (LVib > PVib)
        {
            Vib = LVib;
        }
    
       // Vib = Mathf.Clamp01(Vib);
            //Changer.color = Color.HSVToRGB( Hue, Sat, Vib);
        Changer.color = GetColorWheelColor(ColorWheelOrigin,GetPositionOnColorWheel(ColorWheelOrigin,transform.position),Vib);
       Changer.SetColor("_EmissionColor", Changer.color);
    }

    public static Color GetColorWheelColor(Transform colorWheel, Vector2 colorWheelPos, float value)
    {
        //vector2 is some vector that is a direction, magnitude between 0 and 1.
        float angle = Vector2.SignedAngle(colorWheel.forward, colorWheelPos.normalized);
        if (angle < 0)
        {
            angle = 360 + angle;
        }
        float saturation = colorWheelPos.magnitude;
        float hue = angle / 360f;
        Debug.Log(angle);
        return Color.HSVToRGB(hue,saturation,value);
    }
    public  static Vector2 GetPositionOnColorWheel(Transform colorWheel, Vector3 worldPosition)
    {
        //todo: all of the work
        //convert world to local-relative-to-color-wheel
        //project onto wheel/get angle
        var local = colorWheel.InverseTransformPoint(worldPosition);
        if (local.magnitude > 1)
        {
            local = local.normalized;
        }

        return new Vector2(local.x, local.z);
    }
}
