using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarJuego2 : MonoBehaviour
{


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CargaNivel.NivelCarga("JuegoTwo");
        }
    }

}
