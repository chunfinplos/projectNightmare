using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigthMovement : MonoBehaviour {

	private bool overlap = false;
	public float speed = 8;
	private Vector3 direction;

	public Transform center;
	public Transform bind;
	private bool isAttached = false;

	void Start () {}

	void Update () {
		if (!isAttached) {
			if (overlap) {
				transform.Translate (direction * Time.deltaTime, Space.World);
			} else {
				transform.position = Vector3.MoveTowards (transform.position, center.transform.position, speed * Time.deltaTime);
			}
		} else {
			transform.position = Vector3.MoveTowards (transform.position, bind.transform.position, speed * Time.deltaTime);
		}
	}

	void OnTriggerStay(Collider other) {
		if (!isAttached) {
			float x = transform.position.x - other.transform.position.x;
			float z = transform.position.z - other.transform.position.z;
			direction.Set (x, 0, z);
		}
	}
		
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Finish") {
			Debug.Log (other.tag);
			isAttached = true;
		}
		overlap = true;
	}

	void OnTriggerExit(Collider other) {
		overlap = false;
	}
}
