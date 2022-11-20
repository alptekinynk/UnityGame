using TMPro;
using UnityEngine;

public class T2Start : MonoBehaviour
{
    [SerializeField] GameObject tapToStart;
    public static bool gameStart = false;
    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        tapToStart.SetActive(false);
        gameStart = true;
    }
}
