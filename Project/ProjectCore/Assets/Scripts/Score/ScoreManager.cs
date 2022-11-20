using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private HeroStackController heroStackController;
    public Transform hero;
    public Text scoreText;
    public int score;
    
   
    private void Start()
    {
        score = 0;
        PlayerPrefs.SetInt("Score", score);
        scoreText.text = score.ToString();
        heroStackController = GameObject.FindObjectOfType<HeroStackController>();

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ScoreCalculate().ToString();
       // Debug.Log(hero.position.z);
    }

    public int ScoreCalculate()
    {
        score = 0;
        score = (heroStackController.blockList.Count *5)* (int)(hero.position.z - 7.88584);
        PlayerPrefs.SetInt("Score", score);
        return score;
    }
}
