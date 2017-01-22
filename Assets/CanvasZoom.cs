using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasZoom : MonoBehaviour {

   
    public GameObject imagen;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(this.transform.position.z > -12)
        this.transform.Translate(0,0, -1 * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
			Application.Quit();


    }
}
