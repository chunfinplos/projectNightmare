using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonPotencia : MonoBehaviour {

    [SerializeField]
    private GameObject mg;

    private GameObject[] botonesSubir;
    
    private GameObject[] botonesBajar;

    public void Accion()
    {
        if (this.gameObject.tag == "Palanca")
        {
            mg.GetComponent<MagnetManager>().lanzarBola();
            print("Bola Lanzada");
        }
        botonesSubir = GameObject.FindGameObjectsWithTag("BotonesSubirImanes");
        botonesBajar = GameObject.FindGameObjectsWithTag("BotonesBajarImanes");

        for (int i = 1; i<=botonesSubir.Length;i++)
        {
            if (this.gameObject.name == "Subir Potencia Iman " + (i))
            {
                if (mg.GetComponent<MagnetManager>().arrayPosBotones[i] < 4)
                {
                    mg.GetComponent<MagnetManager>().arrayPosBotones[i] += 1;
                    print("Pulsacion arriba");
                }
            }
        }
        for (int i = 1; i <= botonesBajar.Length; i++)
        {
            if (this.gameObject.name == "Bajar Potencia Iman " + (i))
            {
                if (mg.GetComponent<MagnetManager>().arrayPosBotones[i] > 0)
                {
                    mg.GetComponent<MagnetManager>().arrayPosBotones[i] -= 1;
                    print("Pulsacion Abajo");
                }
            }
        }

        
    }
}
