using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAction : MonoBehaviour {

    [SerializeField] private float MaxDistance;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame

    void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, MaxDistance))
            print("Found an object - distance: " + hit.distance);

        Debug.DrawRay(transform.position, transform.forward , Color.green);
    }
}
