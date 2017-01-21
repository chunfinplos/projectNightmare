using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerLight : MonoBehaviour {

	public GameObject[] lights = new GameObject[5];
	private int index = 1;
	public float timeDelay = 5;
	
	void Start () {}

	void Update () {}

	public void attachLight(string name) {
		Debug.Log (name);
		StartCoroutine(delay());
	}

	IEnumerator delay() {
		yield return new WaitForSeconds(timeDelay);
		if(index < lights.Length) {
			lights [index].SetActive (true);

			AudioSource audio = GetComponent<AudioSource>();
			audio.Play ();
		}
		index++;
	}
}