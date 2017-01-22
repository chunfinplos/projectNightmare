using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {

    public GameObject estatua;
    public GameObject luz;
    public static bool MusicaCompleto, MagnetismoCompleto, LuzCompleto;
    
    // Use this for initialization
	void Start () {
        MusicaCompleto = false;
        MagnetismoCompleto = false;
        LuzCompleto = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (MusicaCompleto && MagnetismoCompleto && LuzCompleto && estatua != null)
        {
            Destroy(estatua);
            luz.SetActive(true);
        }
	}
}
