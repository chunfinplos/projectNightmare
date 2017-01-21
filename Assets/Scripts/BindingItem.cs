using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BindingItem : MonoBehaviour {

    public GrabbableItem myItem;

    private void OnTriggerEnter(Collider other)
    {
        myItem = other.GetComponent<GrabbableItem>();

        if(myItem!=null)
        {
            if (!myItem.Grabbed)
            {
                other.transform.position = transform.position;
                other.transform.rotation = transform.rotation;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (myItem != null)
            myItem = null;
    }
}
