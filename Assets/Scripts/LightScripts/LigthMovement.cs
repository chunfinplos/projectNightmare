using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigthMovement : MonoBehaviour {

	private bool overlap = false;
	public float speed = 5;
	private Vector3 direction;

	public Transform center;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
		if (overlap) {
			transform.Translate(direction * Time.deltaTime);
		} else {
			transform.position = Vector3.MoveTowards (transform.position, center.transform.position, speed * Time.deltaTime);
		}
	}

	void OnTriggerStay(Collider other) {
		float x = transform.position.x - other.transform.position.x;
		float y = transform.position.y - other.transform.position.y;
		direction.Set (x,y,0);
	}

	void OnTriggerEnter(Collider other) {
		float x = transform.position.x - other.transform.position.x;
		float y = transform.position.y - other.transform.position.y;
		direction.Set (x,y,0);
		overlap = true;
	}

	void OnTriggerExit(Collider other) {
		overlap = false;
	}
}
