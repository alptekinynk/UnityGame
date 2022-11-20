using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject tapToStart;
    public static bool gameStart = false;

    void Start()
    {
        gameStart = false;
    }

    public void StartGame()
    {
        tapToStart.SetActive(false);
        gameStart = true;
        Time.timeScale = 1f;
        
    }

    public void StopGame()
    {
        gameStart=false;    
    }
}
