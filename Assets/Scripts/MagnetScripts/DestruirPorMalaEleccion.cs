using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPorMalaEleccion : MonoBehaviour {
    


    void OnTriggerEnter(Collider other)
    {
        GameObject mg = GameObject.FindWithTag("Manager"); 
        if (other.gameObject.tag.Equals("Bola"))
        {
            print("La bola entra y muere");
            mg.GetComponent<MagnetManager>().BolaEnMovimiento = false;
            Destroy(other.gameObject);
        }
    }
}
