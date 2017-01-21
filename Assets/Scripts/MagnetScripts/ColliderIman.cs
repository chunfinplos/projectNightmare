using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderIman : MonoBehaviour {
    [SerializeField]
    private GameObject mg;

    void OnTriggerEnter(Collider other)
    {
        print("La bola entra");
        mg.GetComponent<MagnetManager>().bolaEnMovimiento = false;
    }
}
