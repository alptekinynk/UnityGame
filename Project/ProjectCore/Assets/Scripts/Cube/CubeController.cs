using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeController : MonoBehaviour
{
    [SerializeField] private HeroStackController heroStackController;

    private Vector3 direction = Vector3.back;
    private bool isStack = false;  
    private RaycastHit hit;
    [SerializeField] bool isMainCube;


    // Start is called before the first frame update
    void Start()
    {
        heroStackController = GameObject.FindObjectOfType<HeroStackController>();
        if (isMainCube)
        {
            direction = Vector3.forward;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (!GameManager.gameStart)
        {
            return;
        }
        SetCubeRaycast();
    }

    
    private void SetCubeRaycast()
    {
        //if (Physics.Raycast(transform.position, direction, out hit, 0.0505f))
        bool isHitted = Physics.BoxCast(transform.position, new Vector3(0.0505f, 0.0505f, 0.0505f) * 0.5f, direction,out hit,transform.rotation, 0.0101f);
        
        if (isHitted)
        {
            if (!isStack)
            {
                isStack = true;
                if (gameObject.name == "MainCube")
                {
                    return;
                }
                else
                {
                    heroStackController.IncreaseBlockStack(gameObject);
                    SetDirection(); 
                }          
            }  
            if ((hit.transform.name == "CubeRed") && (gameObject.name=="MainCube"))
            {
                Debug.Log("GAME OVER");
                PlayerBehaviour.Instance.FailAnimation();
                //LoadGameOver();



            }
            else if (hit.transform.name == "CubeRed")
            {
                heroStackController.DecreaseBlockStack(gameObject);
            }
            else if (hit.transform.name == "Final")
            {
                PlayerBehaviour.Instance.VictoryAnimation();
                //Time.timeScale = 0f;
                //LoadEndLevel();


            }
        }
    }
    private void SetDirection()
    {
        direction = Vector3.forward;
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
