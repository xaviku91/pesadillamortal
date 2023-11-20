using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Metodo para cargar la escena de la intro del juego desde el menu.
    public  void EscenaIntro()
    {
        SceneManager.LoadScene("sceneIntro");
    }

    // Metodo para cargar la escena de opciones en el menu.
    public void cargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    // Metodo para salir del juego.
    public void Salir()
    {
        Application.Quit(); //Quitar el juego.
    }
}