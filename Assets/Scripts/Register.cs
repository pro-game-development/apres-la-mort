using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Register : MonoBehaviour
{
    public string objectInside = ""; 
    public TextMeshProUGUI registerMessage;
    private bool isColliding = false; 
    public TextMeshProUGUI nothingFound;
    public TextMeshProUGUI keyFound;

    void Start(){
        registerMessage.gameObject.SetActive(false);
        nothingFound.gameObject.SetActive(false);
        keyFound.gameObject.SetActive(false);
    }

    void Update(){
        if(isColliding && Gamepad.current != null && Gamepad.current.buttonWest.wasPressedThisFrame){
            if(objectInside != ""){
                // Add the item to the player's inventory
                InventoryManager.AddItem(objectInside);
                registerMessage.gameObject.SetActive(false);
                keyFound.gameObject.SetActive(true);
                objectInside = "";
            }
            else{
                registerMessage.gameObject.SetActive(false);
                nothingFound.gameObject.SetActive(true);
            }
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            registerMessage.gameObject.SetActive(true);
            isColliding = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            registerMessage.gameObject.SetActive(false);
            nothingFound.gameObject.SetActive(false);
            keyFound.gameObject.SetActive(false);
            isColliding = false;
        }
    }

    public static class InventoryManager
    {
        public static void AddItem(string itemName)
        {
            // Find the inventory object and add the item
            Inventory inventory = Resources.Load<Inventory>("Inventory");
            inventory.AddToInventory(itemName);

        }
    }
}
