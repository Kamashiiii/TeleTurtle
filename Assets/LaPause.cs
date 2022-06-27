using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaPause : MonoBehaviour
{
    public static bool JeuEnPause = false;
    public GameObject MenuPauseUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(JeuEnPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        
    }
    public void Resume()
    {
        MenuPauseUI.SetActive(false);
        Time.timeScale = 1f;
        JeuEnPause = false;
    }
    public void Pause()
    {
        MenuPauseUI.SetActive(true);
        Time.timeScale = 0f;
        JeuEnPause = true;
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
