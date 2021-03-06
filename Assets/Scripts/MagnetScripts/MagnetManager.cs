﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MagnetManager : MonoBehaviour {

    [SerializeField]
    private GameObject platLanzamiento;

    [SerializeField]
    private GameObject[] imanes = new GameObject[6];

    [SerializeField]
    private GameObject bola;

    private GameObject bol;

    private Vector3 resta;


    public GameObject player;

    private bool completo = false;

	[SerializeField]
	Text estadoImanes;

    [SerializeField]
    public int[] arrayPosBotones = new int[6];

    [SerializeField]
    private int[] posCorrectas = new int[6];
    [SerializeField]
    private GameObject[] situacionesFallidas = new GameObject[20];

    public bool esCorrecto = true;

    public bool bolaEnMovimiento = false;
    [SerializeField]
    private int velMov;

    [SerializeField]
    private int i = 0, j;

    private Fade fade;

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
        fade = GetComponent<Fade>();
        posCorrectas[0] = 0;
        posCorrectas[1] = 3;
        posCorrectas[2] = 1;
        posCorrectas[3] = 0;
        posCorrectas[4] = 4;
        posCorrectas[5] = 2;
        arrayPosBotones[0] = 0;
        arrayPosBotones[1] = 0;
        arrayPosBotones[2] = 0;
        arrayPosBotones[3] = 0;
        arrayPosBotones[4] = 0;
        arrayPosBotones[5] = 0;
        BolaEnMovimiento = false;
    }

    // Update is called once per frame
    void Update() {
        if (bol != null)
        {
            if (i < 5)
            {
                if (!BolaEnMovimiento)
                {
                    if (arrayPosBotones[i] == posCorrectas[i])
                    {

                        esCorrecto = true;
                        BolaEnMovimiento = true;
                        i++;
                        resta = imanes[i].transform.position - bol.transform.position;
						print ("Yendo hacia iman "+ imanes[i]);
                        if (i == 2 && arrayPosBotones[5] != posCorrectas[5])
                            resta = imanes[5].transform.position - bol.transform.position;
                    }
                    else
                    {
                        esCorrecto = false;
                        bolaEnMovimiento = true;
                        if (arrayPosBotones[i] != posCorrectas[i])
                        {
                            switch (arrayPosBotones[i])
                            {
                                case 0:
                                    j = i * 4;
                                    break;
                                case 1:
                                    j = i * 4 + 1;
                                    break;
                                case 2:
                                    j = i * 4 + 2;
                                    break;
                                case 3:
                                    j = i * 4 + 3;
                                    break;
                                case 4:
                                    j = i * 4 + 4;
                                    break;
                                default:
                                    break;
                            }
                            j -= 4;
                            resta = situacionesFallidas[j].transform.position - bol.transform.position;
                            i = 0;
                        }
                    }
                }
                else
                {
                    viajeIman();
                }
            }
            else
            {
                Destroy(bol);
				estadoImanes.text = "";
                completo = true;

				print ("Primera entrada");
                if (completo)
                {
					print ("Segunda entrada");

                    
						print ("Tercera entrada");
                        RoomManager.MagnetismoCompleto = true;
                        completo = false;
                    

                }
            }
        }
    }

    public void lanzarBola()
    {
		estadoImanes.text = "El estado de los imanes es: " +arrayPosBotones[1]+" "+ arrayPosBotones[2]+" "+arrayPosBotones[3]+" "+arrayPosBotones[4]+" "+arrayPosBotones[5];
        bol = Instantiate(bola, platLanzamiento.transform.position, platLanzamiento.transform.rotation);
    }

    private void viajeIman()
    {
		bol.transform.Translate(resta * Time.deltaTime/3,Space.World);

    }

}
