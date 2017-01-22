using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerLight : MonoBehaviour {

    public GameObject player;
	public GameObject[] lights = new GameObject[5];
	private int index = 1;
	public float timeDelay = 5;
	private bool finish = false;

    //private float contador=0;

	void Start () {
		Fade fade = GetComponent<Fade>();
		fade.StartFade();
	}

	void Update () {
        if (finish && RoomManager.LuzCompleto == false)
        {
            finish = false;
            Fade fade = GetComponent<Fade>();
            fade.StartFade();

            //contador += Time.deltaTime;
            //if (contador >= fade.aFadeInTime)
            //{
                RoomManager.LuzCompleto = true;
                player.transform.position = new Vector3(-0.14f, 0.75f, 0.38f);
            //}
        }

    }

	public void attachLight(string name) {
		Debug.Log (name);
		StartCoroutine(delay());
	}

	IEnumerator delay() {
		yield return new WaitForSeconds(timeDelay);
		if (index < lights.Length-1) {
			lights [index].SetActive (true);

			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
			index++;
		} else {
			finish = true;
		}
	}
}