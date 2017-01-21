using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableItem : MonoBehaviour {

    GameObject player = null;
    Rigidbody rb;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    public void Grab(GameObject player)
    {
        this.player = player;
        this.transform.parent = player.transform;
        rb.isKinematic = true;
        
    }

    public void Drop()
    {
        this.transform.parent = null;
        this.player = null;
        rb.isKinematic = false;
    }
}
