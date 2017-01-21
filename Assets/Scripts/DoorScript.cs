using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    bool isOpen = false;
    public void Move()
    {
        if (isOpen)
        {
            isOpen = false;
            gameObject.transform.Rotate(new Vector3(0, 0, 90));
        }
        else
        {
            isOpen = true;
            gameObject.transform.Rotate(new Vector3(0, 0, -90));
        }
    }

    
}
