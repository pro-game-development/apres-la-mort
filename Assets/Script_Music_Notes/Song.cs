using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song : MonoBehaviour
{
    private string[] notes = {"MI","FA","MI","RE","RE","MI","RE",
                              "DO","DO","RE","DO","SI","DO","SI","LA"};
    // private string[] notes = {"MI","FA","MI"};
    private static int currentNote = 0;
    public static bool hasWon = false;
    public PlayerHP playerHP; // reference to the PlayerHP script

    void Start(){
        playerHP = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHP>();
    }
    public void checkNote(string playedNote)
    {
        Debug.Log("current note: " + currentNote + " " + notes[currentNote]);
        if (hasWon)
        {
            return;
        }
        if (playedNote == notes[currentNote])
        {
            currentNote++;
        }
        else
        {
            currentNote = 0;
            PlayerHP playerHP = GameObject.FindWithTag("Player").GetComponent<PlayerHP>();
            if(playerHP != null)
            {
                playerHP.hp -= 10;
                Debug.Log("hp: " + playerHP.hp);
            }
            else
            {
                Debug.Log("PlayerHP component not found!");
            }
        }

        if (currentNote > 14)
        {
            Inventory inventory = Resources.Load<Inventory>("Inventory");
            inventory.AddToInventory("CameraPiece1");
            hasWon = true;
            currentNote = 0;
            Debug.Log("win");
        }
    }
}
