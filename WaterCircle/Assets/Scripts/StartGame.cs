using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{


    
    void Start()
    {

    }

    
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "DropAnimation") { SceneManager.LoadScene("Start"); }


    }

}
