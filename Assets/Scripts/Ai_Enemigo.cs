using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ai_Enemigo : MonoBehaviour
{

    public Transform Objetivo; 
    public float Velocidad; 
    public NavMeshAgent IA; 

    public Animation Animacion;
    public string NombreAnimacionCaminar;
    public string NombreAnimacionAtacar;


    void Update()
    {
        IA.speed = Velocidad; // La velocidad del enemigo es igual a la velocidad que le asignemos en el inspector de Unity.
        IA.SetDestination(Objetivo.position); // El enemigo se mueve hacia el objetivo (player).

        if (IA.velocity == Vector3.zero) // Si la velocidad del enemigo es igual a cero, entonces...
        {
            Animacion.CrossFade(NombreAnimacionAtacar); // El enemigo ataca.
        }
        else // Si no...
        {
            Animacion.CrossFade(NombreAnimacionCaminar); // El enemigo camina.
        }
    }
}
