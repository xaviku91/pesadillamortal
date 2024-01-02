
using UnityEngine;

public class OnLoadTwoo : MonoBehaviour
{
    // Define la posici�n a la que quieres que se mueva el personaje al cargar la escena
    public Vector3 nuevaPosicion = new Vector3(0.419f, 0.505f, -0.235f);

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
            // Accede al componente Transform y cambia la posici�n
            completePlayer.transform.position = nuevaPosicion;

            // Encuentra el subobjeto Player dentro de CompletePlayer
            playerObject = completePlayer.transform.Find("Player").gameObject;

            if (playerObject != null)
            {
                // Modificamos la posicion del player con el uso de un Vector3
                playerObject.transform.position = new Vector3(0.1f, 0.2f, -0.235f);
                // Imprime las coordenadas iniciales del objeto Player
                Debug.Log("Posici�n inicial de Player: " + playerObject.transform.position);
            }
            else
            {
                Debug.LogError("No se encontr� un subobjeto llamado Player dentro de CompletePlayer.");
            }
        }
        else
        {
            Debug.LogError("No se encontr� un objeto llamado CompletePlayer en la escena.");
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}