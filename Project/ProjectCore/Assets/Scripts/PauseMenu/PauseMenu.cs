using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    void Update()
    {
        
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu"); 
        
    }
    public void Resume()
    {
        Time.timeScale = 1f;
    }
    public void Pause()
    {
        Time.timeScale = 0f;

    }
    public void Quit()
    {
        Debug.Log("Oyun Kapandý");
        Application.Quit();
    }
}
