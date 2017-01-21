using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerLight : MonoBehaviour {

	public GameObject[] lights = new GameObject[5];
	private int index = 1;
	
	void Start () {}

	void Update () {}

	public void attachLight(string name) {
		Debug.Log (name);
		if(index < lights.Length) {
			lights [index].SetActive (true);
		}
		index++;
	}
}