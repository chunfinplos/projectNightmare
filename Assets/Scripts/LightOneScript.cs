using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOneScript : MonoBehaviour {

    public bool on = false;

    GameObject lightGameObject;
    Light lightComp;

    public Color color;
    public float intensity = 1;

    private void Start()
    {
        lightGameObject = new GameObject("Luz");
        lightComp = lightGameObject.AddComponent<Light>();
        lightComp.color = color;
        lightGameObject.transform.position = gameObject.transform.position;
        lightComp.enabled = on;
        lightComp.intensity = intensity;
    }

    public void turnLight()
    {
        if (lightComp.enabled == false)
            lightComp.enabled = true;
        
        else
            lightComp.enabled = false;
    }
}
