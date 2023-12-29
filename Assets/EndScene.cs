using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndScene : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
            SceneManager.LoadScene("EndScene");
    }

}
