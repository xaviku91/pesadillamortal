
using UnityEngine;

public class OnSceneLoadTwoo : MonoBehaviour
{
    // Define la posición a la que quieres que se mueva el personaje al cargar la escena
    public Vector3 nuevaPosicion = new Vector3(-24f, -1.08f, 22f);

    // Referencia al objeto CompletePlayer
    private GameObject completePlayer;


    // Start is called before the first frame update
    void Start()
    {
        // Busca el objeto CompletePlayer en la escena
        completePlayer = GameObject.Find("Player");

        // Verifica si el objeto CompletePlayer existe
        if (completePlayer != null)
        {
            // Accede al componente Transform y cambia la posición
            completePlayer.transform.position = nuevaPosicion;

            
        }
        else
        {
            Debug.LogError("No se encontró un subobjeto llamado Player dentro de CompletePlayer.");
        }
    }
   
}

  
