using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirCajon : MonoBehaviour {

    bool estaAbierto = false;

	public void Accion()
    {
        if (estaAbierto)
        {
            transform.Translate(new Vector3(1, 0, 0));
            estaAbierto = false;
        }
        else
        {
            transform.Translate(new Vector3(-1, 0, 0));
            estaAbierto = true;
        }
    }
}
