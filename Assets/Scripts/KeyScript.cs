using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public DoorScript doorToOpen;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            doorToOpen.isUnlocked = true;
            Destroy(gameObject); 
        }
    }
}
