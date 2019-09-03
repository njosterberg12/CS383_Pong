using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame ()
    {
        // loads the next scene in the build queue which is Play
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }

    public void QuitGame()
    {
        // Quit to exit game; "Quit" is sent to the console instead of new scene to finish the application
        Debug.Log("Quit");
        Application.Quit();
    }
}
