using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigthMovement : MonoBehaviour {

	private bool overlap = false;
	public float speed = 8;
	private Vector3 direction;

	public Transform center;
	public GameObject bind;
	private bool isAttached = false;

	public float timeDelay = 3;
	private float tempDelay = 0;

	void Start () {}

	void Update () {
		tempDelay += Time.deltaTime;
		if (!isAttached) {
			if (overlap) {
				tempDelay = 0;
				transform.Translate (direction * Time.deltaTime, Space.World);
			} else {
				if(tempDelay >= timeDelay) {
					transform.position = Vector3.MoveTowards (transform.position, center.transform.position, speed * Time.deltaTime);
				}
			}
		} else {
			transform.position = Vector3.MoveTowards (transform.position, bind.transform.position, speed * Time.deltaTime);
		}
	}

	void OnTriggerStay(Collider other) {
		if (!isAttached && other.tag == "Player") {
			float x = transform.position.x - other.transform.position.x;
			float z = transform.position.z - other.transform.position.z;
			direction.Set (x, 0, z);
		}
	}
		
	void OnTriggerEnter(Collider other) {
		if (other.gameObject == bind) {
			Debug.Log ("Finish");
			isAttached = true;
			ManagerLight mgr = GameObject.Find("SalaLuces").GetComponent<ManagerLight>();
			mgr.attachLight (name);
		} else if(other.tag == "Player") {
			overlap = true;
		}
	}

	void OnTriggerExit(Collider other) {
		if(other.tag == "Player") {
			overlap = false;
		}
	}
}
