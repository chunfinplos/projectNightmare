using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRoom : MonoBehaviour {

	private BindingItem binding;
	public string name = "medallon_musica";

	void Start () {}

	void Update () {}

	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.name == name) {
			Destroy (collision.gameObject);
			Destroy (gameObject);
		}
	}
}
