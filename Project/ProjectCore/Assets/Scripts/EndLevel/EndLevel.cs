using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public TextMeshProUGUI scoreValue;
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        scoreValue.text = PlayerPrefs.GetInt("Score",0).ToString();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void NextLevel()
    {
        level = PlayerPrefs.GetInt("Level", 1)+1;
        if (level == 6)
        {
            level = 3;
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            PlayerPrefs.SetInt("Level", level);
            SceneManager.LoadScene(level);
        }
        


    }
}
