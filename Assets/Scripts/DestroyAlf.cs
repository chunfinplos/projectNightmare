using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAlf : MonoBehaviour {

    bool destroy = false;
    public GameObject alf;

    GameObject lightGameObject;
    Light lightComp;
    private void Start()
    {
        lightGameObject = new GameObject("Luz");
    }

    public void DestroyAlfo()
    {
        if (destroy == false)
        {
            lightComp = lightGameObject.AddComponent<Light>();
            lightComp.color = Color.white;
            lightGameObject.transform.position = new Vector3(1.84f, 1.56f, -1.61f);

            Destroy(alf);
            destroy = true;
        }
    }
}
