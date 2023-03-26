using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory")]
public class Inventory : ScriptableObject
{
    // Define the inventory list as a class variable
    public List<string> inventory = new List<string>();

    // Add an item to the inventory list
    public void AddToInventory(string itemName)
    {
        inventory.Add(itemName);
    }

    // Display the inventory list in the console
    public void ShowInventoryList()
    {
        Debug.Log("Inventory: " + string.Join(", ", inventory));
    }

    public GameObject GetAndRemoveFirstItem(Transform playerTransform, GameObject itemPrefab, string itemName)
    {
        if (inventory.Count > 0)
        {
            // Get the name of the first item in the inventory
            Inventory inventory = Resources.Load<Inventory>("Inventory");
            
            // int index = -1;
            // int itemIndex = 0;
            // foreach(string inventoryItem in inventory.inventory){
            //     if(inventoryItem == "flashLight"){
            //         itemIndex = index;
            //     }
            //     index++;
            // }

            int itemIndex = inventory.inventory.FindIndex(item => item == itemName);


            Debug.Log("index: " + itemIndex);

            // Remove the item from the inventory
            inventory.inventory.RemoveAt(itemIndex);

            // Instantiate the item prefab in front of the player
            Vector3 itemPosition = playerTransform.position + playerTransform.forward * 2.0f;
            Debug.Log("Item position: " + itemPosition);
            GameObject item = Instantiate(itemPrefab, itemPosition, Quaternion.identity);

            // Set the item name as the object name
            item.name = itemName;

            // Return the instantiated item object
            return item;
        }
        else
        {
            // Return null if the inventory is empty
            return null;
        }
    }
}



