using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Cargando : MonoBehaviour
{
    public Text texto;

    private void Start()
    {
        string nivelACargar = CargaNivel.siguienteNivel;

        StartCoroutine(IniciarCarga(nivelACargar));
    }

    IEnumerator IniciarCarga(string nivel)
    {
        AsyncOperation operacion = SceneManager.LoadSceneAsync(nivel);
        operacion.allowSceneActivation = false;

        while (!operacion.isDone)
        {
            if (operacion.progress >= 0.9f) 
            {
                texto.text = "Presiona cualquier tecla para continuar";     
                
                if (Input.anyKey) 
                {
                    
                    operacion.allowSceneActivation = true;
                }
            }
            yield return null;
        }
    }
}
