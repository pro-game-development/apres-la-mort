using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ItemPickup : MonoBehaviour
{
    public string itemName;
    public float pickupRange = 1f;
    
    //private void OnTriggerEnter(Collider other)
    private void Update()
    {
        if (Vector3.Distance(transform.position, PlayerManager.instance.player.transform.position) <= pickupRange && Gamepad.current != null && Gamepad.current.buttonWest.wasPressedThisFrame)
        {
            // Add the item to the player's inventory
            InventoryManager.AddItem(itemName);
            // Destroy the item in the game world
            Destroy(gameObject);
        }
    }
}

public static class InventoryManager
{
    private static List<string> inventory = new List<string>();
    
    public static void AddItem(string itemName)
    {
        // Find the inventory object and add the item
        Inventory inventory = Resources.Load<Inventory>("Inventory");
        inventory.AddToInventory(itemName);

    }
}
