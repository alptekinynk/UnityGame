using UnityEngine;

public class HeroInputController : MonoBehaviour
{
    private float horizontalValue;

    public float HorizontalValue
    {
        get { return horizontalValue; }
    }



    void Update()
    {
        if (!GameManager.gameStart)
        {
            return;
        }
        HandleHeroHorizontalInput();
    }



    private void HandleHeroHorizontalInput()
    {
        //horizontalValue = (float)(Input.GetAxis("Horizontal"));
        
        
        if (Input.GetMouseButton(0))
        {
            horizontalValue = (float)(Input.GetAxis("Mouse X"));
            //horizontalValue = (Input.GetTouch("");
        }
        else
        {
            horizontalValue = 0;
        }
    }
}