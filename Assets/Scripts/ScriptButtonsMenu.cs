using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptButtonsMenu : MonoBehaviour {

	public void salir()
    {
		print ("Salir Pulsado");
        Application.Quit();
    }

    public void jugar()
    {
		print ("Jugar Pulsado");
        SceneManager.LoadScene("MainFinalScene");
    }
}
