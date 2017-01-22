using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptButtonsMenu : MonoBehaviour {

	public void salir()
    {
        Application.Quit();
    }

    public void jugar()
    {
        SceneManager.LoadScene("MainFinalScene");
    }
}
