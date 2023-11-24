using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipIntro : MonoBehaviour
{

    void Start()
    {
        
    }

  
    void Update()
    {
        // Cualquier tecla.
        if (Input.anyKey)
        {
            SceneManager.LoadScene("juegoOne");
        }
        
    }
}
