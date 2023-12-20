using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarNivel : MonoBehaviour
{
    public void CambiarEscena()
    {
        CargaNivel.NivelCarga("JuegoThree"); 
    }
}
