using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Gets the current scene of the program and increments by 1. This loads the next scene in the build index.
    }

    public void ExitGame()
    {
        Debug.Log("Success");
        Application.Quit(); 
    }
   
}
