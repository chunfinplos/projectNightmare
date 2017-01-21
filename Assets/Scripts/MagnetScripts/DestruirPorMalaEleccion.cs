﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPorMalaEleccion : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Bola"))
        {
            print("La bola entra y muere");
            Destroy(other.gameObject);
        }
    }
}
