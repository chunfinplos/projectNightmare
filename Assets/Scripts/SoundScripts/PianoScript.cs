using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoScript : MonoBehaviour {


    private bool playing = false;

    public void Play()
    {
        if (playing == false)
        {
            playing = true;

            BindingItem[] item = GetComponentsInChildren<BindingItem>();

            if (item[0].myItem.Id == "Peon")
            {
                print("Exito");
            }

            playing = false;
        }
        
    }
}
