using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStackController : MonoBehaviour
{
    public List<GameObject> blockList = new List<GameObject>();

    private GameObject lastBlockObject;


    // Start is called before the first frame update
    void Start()
    {
       UpdateLastBlockObject();
    }


    public void IncreaseBlockStack(GameObject _gameObject)
    {    
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.0514f, transform.position.z);
        _gameObject.transform.position = new Vector3(lastBlockObject.transform.position.x, lastBlockObject.transform.position.y - 0.0514f, lastBlockObject.transform.position.z);
        _gameObject.transform.SetParent(transform);
        blockList.Add(_gameObject);
        UpdateLastBlockObject();
    }

    public void DecreaseBlockStack(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        blockList.Remove(_gameObject);
        UpdateLastBlockObject();
    }
   

    private void UpdateLastBlockObject()
    {
        lastBlockObject = blockList[blockList.Count - 1]; 
    }
}
