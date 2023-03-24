using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PuertaGeneral : MonoBehaviour
{
    public Animator puerta;
    private bool enZona;
    private bool activa;

    void Update()
    {
        if(Gamepad.current != null && Gamepad.current.buttonWest.wasPressedThisFrame && enZona == true)
        {
            activa = !activa;

            if(activa == true)
            {
                puerta.SetBool("PuertaActiv", true);
            }

            if(activa == false)
            {
                puerta.SetBool("PuertaActiv", false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            enZona = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enZona = false;
        }
    }
}
