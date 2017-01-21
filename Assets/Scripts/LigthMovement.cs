using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigthMovement : MonoBehaviour {

	private bool overlap = false;
	public float speed = 5;
	private Vector3 direction;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
		if(overlap){
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, direction, step);
		}
	}

	void OnTriggerStay(Collider other) {
		direction = other.transform.forward;
	}

	void OnTriggerEnter(Collider other) {
		direction = other.transform.forward;
		overlap = true;
	}

	void OnTriggerExit(Collider other) {
		overlap = false;
	}
}
