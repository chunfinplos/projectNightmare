using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planoAstralScript : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        other.transform.position = new Vector3(-0.14f, 0.75f, 0.38f);
    }
}
