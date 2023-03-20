using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script for an empty object to manage the player interaction with items

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance; // Singleton instance of the player manager
    public GameObject player; // Reference to the player object in the scene

    private void Awake()
    {
        // Set up the singleton instance
        if (instance == null)
        {
            instance = this;
            Debug.Log(instance);
        }
        else
        {
            Destroy(gameObject);
        }

        // Find the player object in the scene
        player = GameObject.FindGameObjectWithTag("Player");
    }
}
