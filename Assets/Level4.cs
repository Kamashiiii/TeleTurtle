using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4 : MonoBehaviour
{
    public void Jouer4()
    {
        SceneManager.LoadScene(7);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}