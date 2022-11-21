using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Slider SpeedSlider;
    public float speed;
    public int level;

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
        level = 3;
        PlayerPrefs.SetInt("Level", level);

    }
    void Update()
    {
        SetSpeed();
    }

    public void SetSpeed()
    {
        speed = SpeedSlider.value;
        Debug.Log(speed);
        PlayerPrefs.SetFloat("Speed", speed);
    }
    public void QuitGame()
    {
        Debug.Log("Oyun Kapandý");
        Application.Quit();
    }
}
