using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoPasos : MonoBehaviour
{
    public Transform Player; // El player.
    public Transform Ghoul; // El monstruo.
    public AudioSource Sonido; // El sonido de los pasos.
    public float VolumenBase = 1.0f; // Volumen base del sonido.
    public float DistanciaMaxima = 10.0f; // Distancia máxima a la que se escucharán los pasos.

    void Update()
    {
        float distancia = Vector3.Distance(Player.position, Ghoul.position);
        
        // Asegurarse de que la distancia no sea cero o negativa.
        if (distancia > 0)
        {
            // Calcular el volumen en función de la distancia.
            float volumen = VolumenBase / distancia;

            // Limitar el volumen máximo para evitar que sea demasiado fuerte.
            volumen = Mathf.Clamp(volumen, 0.0f, 1.0f);

            // Aplicar el volumen al sonido.
            Sonido.volume = volumen;
        }
        else
        {
            // Si la distancia es cero, establecer el volumen base.
            Sonido.volume = VolumenBase;
        }
    }
}
