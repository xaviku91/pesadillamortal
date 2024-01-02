
using UnityEngine;

public class OnLoadThree : MonoBehaviour
{
    // Define la posición a la que quieres que se mueva el personaje al cargar la escena
    public Vector3 nuevaPosicion = new Vector3(-22.08f, -1.08f, 66.11f);

    // Referencia al objeto CompletePlayer
    private GameObject completePlayer;

    // Referencia al subobjeto Player dentro de CompletePlayer
    private GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {
        // Busca el objeto CompletePlayer en la escena
        completePlayer = GameObject.Find("CompletPlayer");

        // Verifica si el objeto CompletePlayer existe
        if (completePlayer != null)
        {
            // Accede al componente Transform y cambia la posición
            completePlayer.transform.position = nuevaPosicion;

            // Encuentra el subobjeto Player dentro de CompletePlayer
            playerObject = completePlayer.transform.Find("Player").gameObject;
            
            if (playerObject != null)
            {
                // Modificamos la posicion del player con el uso de un Vector3
                playerObject.transform.position = new Vector3(-6f, -1.08f, 45f);
                // Imprime las coordenadas iniciales del objeto Player
                Debug.Log("Posición inicial de Player: " + playerObject.transform.position);
            }
            else
            {
                Debug.LogError("No se encontró un subobjeto llamado Player dentro de CompletePlayer.");
            }
        }
        else
        {
            Debug.LogError("No se encontró un objeto llamado CompletePlayer en la escena.");
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
