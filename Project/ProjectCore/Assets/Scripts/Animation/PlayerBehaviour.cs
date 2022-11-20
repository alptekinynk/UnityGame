using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private Animator animatorOfPlayer;
    

    private void Awake()
    {
        Singleton();
    }

    #region Singleton

    public static PlayerBehaviour Instance;

    private void Singleton()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        Instance = this;
    }
    #endregion

    public void VictoryAnimation()
    {
        animatorOfPlayer.SetTrigger("Victory");
    }

    public void FailAnimation()
    {
        animatorOfPlayer.SetTrigger("Fail");
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void LoadEndLevel()
    {
        SceneManager.LoadScene("EndLevel");
    }

}
