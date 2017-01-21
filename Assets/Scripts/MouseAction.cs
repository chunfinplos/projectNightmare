﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseAction : MonoBehaviour {


    [SerializeField]
    private float interactionDistance = 2f;

    [SerializeField]
    private Image imagen;

    GrabbableItem gi;

    void FixedUpdate()
    {
        RaycastHit hit;

        Vector3 forward = transform.forward;

        Debug.DrawRay(transform.position, forward * interactionDistance);

        if (Input.GetButtonDown("Accion") && gi != null)
        {
            gi.Drop();
            gi = null;
        }
        else
        {
            if (gi == null)
            {
                if (Physics.Raycast(transform.position, forward, out hit, interactionDistance))
                {
                    imagen.color = Color.green;
                    //print("Found an object - distance: " + hit.collider.gameObject.ToString());

                    if (Input.GetButtonDown("Accion"))
                    {
                        if (hit.collider.gameObject.tag == "BotonesSubirImanes" || hit.collider.gameObject.tag == "BotonesBajarImanes")
                        {
                            print("Boton Apretado");
                            hit.collider.gameObject.GetComponent<BotonPotencia>().Accion();
                        }
                        gi = hit.collider.gameObject.GetComponent<GrabbableItem>();
                        if (gi != null)
                        {
                            gi.Grab(gameObject);
                        }

                        PianoScript ps = hit.collider.gameObject.GetComponent<PianoScript>();
                        if (ps != null)
                        {
                            ps.Play();
                        }

                        DoorScript ds = hit.collider.gameObject.GetComponent<DoorScript>();

                        if (ds != null)
                            ds.Move();

                    }
                }
                else
                {
                    imagen.color = Color.red;
                }
            }
            else
            {
                imagen.color = Color.clear;
            }
        }


    }



}
