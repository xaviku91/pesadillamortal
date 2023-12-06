using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class CogerObjeto : MonoBehaviour
{

    public GameObject handPoint;
    private GameObject objetoCogido = null;


    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("ObjetoLinterna"))
        {
            // Coger objeto linterna con el XR Interaction Toolkit
            if (Input.GetKeyDown(KeyCode.Mouse1) && objetoCogido == null)
            {
                other.GetComponent<Rigidbody>().useGravity = false; // Desactiva la gravedad del objeto
                other.GetComponent<Rigidbody>().isKinematic = true; // Desactiva la fisica del objeto
                other.transform.position = handPoint.transform.position; // Coloca el objeto en la mano
                other.gameObject.transform.SetParent(handPoint.gameObject.transform); // Hace que el objeto sea hijo de la mano
                objetoCogido = other.gameObject; // Guarda el objeto en la variable
            }
        }
    }
}
