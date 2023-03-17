using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInventory : MonoBehaviour
{
    public GameObject flashLight;
    public List<GameObject> itemPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            // Find the inventory object and show the inventory list
            Inventory inventory = Resources.Load<Inventory>("Inventory");
            inventory.ShowInventoryList();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            UseItem(transform, flashLight);
        }
    }

    public static void UseItem(Transform playerTransform, GameObject itemPrefab)
    {
        Inventory inventory = Resources.Load<Inventory>("Inventory");
        GameObject item = inventory.GetAndRemoveFirstItem(playerTransform, itemPrefab, "Flashlight");
        Debug.Log(item);
        if (item != null)
        {
            // Do something with the item object
            Debug.Log("Used item: " + item.name);
            Destroy(item);
        }
        else
        {
            Debug.Log("Inventory is empty!");
        }
    }

}
