using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class ItemPickup : MonoBehaviour
{
    public string itemName;
    public float pickupRange = 1f;
    public Animator ani;
    public TextMeshProUGUI pickupMessage; // The UI text element to display the pickup message

    private void Start()
    {
        pickupMessage.gameObject.SetActive(false); // Hide the pickup message at the start of the game
    }
    
    //private void OnTriggerEnter(Collider other)
    private void Update()
    {
        if (PlayerManager.instance.player == null)
        {
            return;
        }

        if (Vector3.Distance(transform.position, PlayerManager.instance.player.transform.position) <= pickupRange && Gamepad.current != null && Gamepad.current.buttonWest.wasPressedThisFrame)
        {
            ani.SetBool("pick", true);
            // Add the item to the player's inventory
            InventoryManager.AddItem(itemName);
            // Destroy the item in the game world
            Destroy(gameObject);

            pickupMessage.gameObject.SetActive(false);
        }

        else if (Vector3.Distance(transform.position, PlayerManager.instance.player.transform.position) <= pickupRange)
        {   
            // Show the pickup message if the player is close enough to the item
            pickupMessage.gameObject.SetActive(true);
        }
        else
        {
            // Hide the pickup message if the player is too far from the item
            pickupMessage.gameObject.SetActive(false);
            
        }
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
