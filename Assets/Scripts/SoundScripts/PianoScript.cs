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

            if (item[0].name == "Rey" && item[1].name == "Caballo" && item[2].name == "Torre" &&
                item[3].name == "Reina" && item[4].name == "Rey")
            {
                print("Exito");
            }

            playing = false;
        }
        
    }
}
