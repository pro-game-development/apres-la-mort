using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public string itemName;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
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
