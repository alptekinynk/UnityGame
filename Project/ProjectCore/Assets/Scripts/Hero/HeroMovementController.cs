using UnityEngine;

public class HeroMovementController : MonoBehaviour
{
    [SerializeField] private HeroInputController heroInputController;

    [SerializeField] private float horizontalMovementSpeed;

    private float forwardMovementSpeed;
    [SerializeField] private float horizontalLimitValue;

    private float newPositionX;

    void Start()
    {
        forwardMovementSpeed = PlayerPrefs.GetFloat("Speed", 0);
        
    }
    void FixedUpdate()
    {
        if (!GameManager.gameStart)
        {
            return;
        }
        SetHeroForwardMovement();
        SetHeroHorizontalMovement();
        
    }

    private void SetHeroForwardMovement()
    {
        transform.Translate(Vector3.forward * forwardMovementSpeed * Time.fixedDeltaTime);
    }

    private void SetHeroHorizontalMovement()
    {
        newPositionX = transform.position.x + heroInputController.HorizontalValue * horizontalMovementSpeed * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -horizontalLimitValue, horizontalLimitValue);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
}
