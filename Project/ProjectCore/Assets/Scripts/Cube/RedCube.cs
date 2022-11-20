using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedCube : MonoBehaviour
{
    private Vector3 direction = Vector3.forward;
   
    private RaycastHit hit;



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
        bool isHitted = Physics.BoxCast(transform.position, new Vector3(0.0505f, 0.0505f, 0.0505f) * 0.5f, direction, out hit, transform.rotation, 0.0101f);

        if (isHitted)
        {


            if (hit.transform.name == "MainCube")
            {
                Debug.Log("Çarpma oldu ");
            }
            
        }
    }
}
