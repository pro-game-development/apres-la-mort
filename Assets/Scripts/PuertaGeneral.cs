using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PuertaGeneral : MonoBehaviour
{
    public Animator puerta;
    private bool enZona;
    private bool activa;
    public bool needsKey = false;
    private bool canEnter;
    public string neededKey = "";
    public TextMeshProUGUI needKeyMessage;
    public AudioSource OpenDoor;
    public AudioSource CloseDoor;

    void Start(){
        if(needKeyMessage != null){
            needKeyMessage.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        

        if(Gamepad.current != null && Gamepad.current.buttonWest.wasPressedThisFrame && enZona == true)
        {
            if(needsKey && enZona)
            {
                Inventory inventory = Resources.Load<Inventory>("Inventory");
                if(inventory.inventory.Contains(neededKey)){
                    canEnter = true;
                }
                else {
                    canEnter = false;
                    needKeyMessage.gameObject.SetActive(true);
                }
            }
            else canEnter = true;
            
            activa = !activa;

            if(activa == true && canEnter)
            {
                puerta.SetBool("PuertaActiv", true);
                OpenDoor.Play();
            }

            if(activa == false && canEnter)
            {
                puerta.SetBool("PuertaActiv", false);
                CloseDoor.Play();
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
            if(needKeyMessage != null){
                needKeyMessage.gameObject.SetActive(false);
            }
        }
    }
}
