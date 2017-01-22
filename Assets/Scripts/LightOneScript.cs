using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOneScript : MonoBehaviour {

    public bool on = false;

    GameObject lightGameObject;
    Light lightComp;

    public Vector3 position;
    public Color color;

    private void Start()
    {
        lightGameObject = new GameObject("Luz");
        lightComp = lightGameObject.AddComponent<Light>();
        lightComp.color = color;
        lightGameObject.transform.position = position;
        lightComp.enabled = false;
    }

    public void turnLight()
    {
        if (lightComp.enabled == false)
            lightComp.enabled = true;
        
        else
            lightComp.enabled = false;
    }
}
