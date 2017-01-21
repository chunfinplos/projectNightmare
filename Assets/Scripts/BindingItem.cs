using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BindingItem : MonoBehaviour {

    public GrabbableItem myItem;

    private void OnTriggerStay(Collider other)
    {
        GrabbableItem aux = other.GetComponent<GrabbableItem>();

        if(aux!=null)
        {
            if (!aux.Grabbed)
            {
                myItem = aux;
                other.transform.position = transform.position;
                other.transform.rotation = transform.rotation;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<GrabbableItem>())
        {
            if (myItem != null)
                myItem = null;
        }
    }
}
