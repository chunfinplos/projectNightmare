using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableItem : MonoBehaviour {

    public bool Grabbed = false;
    private GameObject player = null;
    private Rigidbody rb;

    

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if(Grabbed)
        {
            this.transform.parent = player.transform;
            rb.useGravity = false;
            rb.freezeRotation = true;
        }
        else
        {
                this.transform.parent = null;
                rb.useGravity = true;
                rb.freezeRotation = false;
            
        }
    }

    public void Grab(GameObject player)
    {
        this.player = player;
        Grabbed = true;
    }

    public void Drop()
    {
        this.player = null;
        Grabbed = false;
    }
}
