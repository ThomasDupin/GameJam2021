using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{

    public string LevelName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

 
    // Update is called once per frame
    void OnTriggerEnter()
    {
        if(GameObject.Find("Key") == null) {
            SceneManager.LoadScene(LevelName);
        } else
        {
            Debug.Log("LA CLE EXISTE");
        }
        
    }
}
