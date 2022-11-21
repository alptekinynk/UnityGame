using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{

    public AudioSource Click;
    public AudioSource Collect;
    public AudioSource GameOver;
    public AudioSource Victory;


    public void PlayClick()
    {
        Click.Play();
    }
    public void PlayCollect()
    {
        Collect.Play();
    }
    public void PlayGameOver()
    {
        GameOver.Play();
    }
    public void PlayVictory()
    {
        Victory.Play();
    }


}
