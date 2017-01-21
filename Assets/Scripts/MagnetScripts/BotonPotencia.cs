using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonPotencia : MonoBehaviour {

    [SerializeField]
    private GameObject mg;

    private GameObject[] botonesSubir;
    
    private GameObject[] botonesBajar;

    void Accion()
    {
        botonesSubir = GameObject.FindGameObjectsWithTag("BotonesSubirImanes");
        botonesBajar = GameObject.FindGameObjectsWithTag("BotonesBajarImanes");

        for (int i = 0; i<botonesSubir.Length;i++)
        {
            if (this.gameObject.name == "Subir Potencia Iman " + (i+1))
            {
                if(mg.GetComponent<MagnetManager>().arrayPosBotones[i] < 4)
                    mg.GetComponent<MagnetManager>().arrayPosBotones[i] += 1; 
            }
        }
        for (int i = 0; i < botonesBajar.Length; i++)
        {
            if (this.gameObject.name == "Bajar Potencia Iman " + (i+1))
            {
                if (mg.GetComponent<MagnetManager>().arrayPosBotones[i] > 0)
                    mg.GetComponent<MagnetManager>().arrayPosBotones[i] -= 1;
            }
        }
    }
}
