using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class GamerOver : MonoBehaviour
{
    public TextMeshProUGUI scoreValue;

    private void Start()
    {

        scoreValue.text = PlayerPrefs.GetInt("Score", 0).ToString();
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
