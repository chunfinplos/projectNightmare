using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigthMovement : MonoBehaviour {

	private bool overlap = false;
	public float speed = 5;
	private Vector3 direction;
	public float delay = 4;
	private float timeDelay = 0;
	private bool isStopped = true;

	public Transform center;

	void Start () {}

	void Update () {
		if (overlap) {
			Debug.Log (direction);
			transform.Translate(direction * Time.deltaTime, Space.World);
		} else {
			transform.position = Vector3.MoveTowards (transform.position, center.transform.position, speed * Time.deltaTime);
		}
	}

	void OnTriggerStay(Collider other) {
		float x = transform.position.x - other.transform.position.x;
		float z = transform.position.z - other.transform.position.z;
		direction.Set (x,0,z);
	}
		
	void OnTriggerEnter(Collider other) {
		overlap = true;
	}

	void OnTriggerExit(Collider other) {
		overlap = false;
	}
}
