using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetManager : MonoBehaviour {

    [SerializeField]
    private GameObject platLanzamiento;

    [SerializeField]
    private GameObject[] imanes = new GameObject[6];

    [SerializeField]
    private GameObject bola;

    private GameObject bol;

    private Vector3 resta;

    [SerializeField]
    private ushort[] arrayPosBotones = new ushort[6];

    [SerializeField]
    private ushort[] posCorrectas = new ushort[6];    

    public bool bolaEnMovimiento = false;
    [SerializeField]
    private int velMov;

    [SerializeField]
    private ushort i = 0;

    public bool BolaEnMovimiento
    {
        get
        {
            return bolaEnMovimiento;
        }

        set
        {
            bolaEnMovimiento = value;
        }
    }

    // Use this for initialization
    void Start () {
        posCorrectas[0] = 3;
        posCorrectas[1] = 1;
        posCorrectas[2] = 0;
        posCorrectas[3] = 4;
        posCorrectas[4] = 2;
        arrayPosBotones[0] = 3;
        arrayPosBotones[1] = 1;
        arrayPosBotones[2] = 0;
        arrayPosBotones[3] = 4;
        arrayPosBotones[4] = 2;
        BolaEnMovimiento = false;
        lanzarBola();
    }

    // Update is called once per frame
    void Update() {

        if (i < 5)
        {
            if (!BolaEnMovimiento)
            {
                if (arrayPosBotones[i] == posCorrectas[i])
                {
                    BolaEnMovimiento = true;
                    i++;
                    resta = imanes[i].transform.position - bol.transform.position;
                }
                else
                {
                    i = 0;
                    return;
                }
            }
            else
            {
                viajeIman(imanes[i]);
            }
        }
        else
        {
            //Lanzar Bola Arriba
        }
        
    }


    private void lanzarBola()
    {
        bol = Instantiate(bola, platLanzamiento.transform.position, platLanzamiento.transform.rotation);
    }

    private void viajeIman(GameObject destino)
    {
        bol.transform.Translate(resta * Time.deltaTime/3);
    }





}
