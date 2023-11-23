using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    // Start is called before the first frame update
    public bool pausa = false;
    public GameObject Menupause;
    public GameObject MenuSalir;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausa == false)
            {
                Menupause.SetActive(true);
                pausa = true;
                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                AudioSource[] sonidos = FindObjectsOfType<AudioSource>();

                for(int a= 0; a< sonidos.Length; a++)
                {
                    sonidos[a].Pause();
                }

            }
            else if (pausa == true)
            {
                Volver();
            }
        }
    }
    public void Volver()
    {
        Menupause.SetActive(false);
        MenuSalir.SetActive(false);
        pausa = false;
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        AudioSource[] sonidos = FindObjectsOfType<AudioSource>();

        for (int a = 0; a < sonidos.Length; a++)
        {
            sonidos[a].Play();
        }
    }

    public void AlMenu(string nombremenu)
    {
        SceneManager.LoadScene(nombremenu);

    }

    public void SalirJuego()
    {
        Application.Quit(); 
    }
}
