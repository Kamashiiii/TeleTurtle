using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level5 : MonoBehaviour
{
    public void Jouer5()
    {
        SceneManager.LoadScene(5);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}