using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class LinternaLuz : MonoBehaviour
{
    
    public Light luzLinterna;
    public bool activarLuz;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            activarLuz = !activarLuz;

            if (activarLuz)
            {
                luzLinterna.enabled = true;
            }
            else
            {
                luzLinterna.enabled = false;
            }
        }   
    }
}
