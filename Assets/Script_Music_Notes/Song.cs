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

    public Camera pianoRoomCamera;

    void Start(){
        pianoRoomCamera = GameObject.FindGameObjectWithTag("PuzzleRoom2").GetComponent<Camera>();
    }

    public void checkNote(string playedNote)
    {
        Debug.Log("current note: " + currentNote + " " + notes[currentNote]);
        if(hasWon){
            return;
        }
        if(playedNote == notes[currentNote]){
            currentNote ++;
        }
        else
        {
            currentNote = 0;
        }
        
        if(currentNote > 14){
            Debug.Log(pianoRoomCamera);
            Inventory inventory = Resources.Load<Inventory>("Inventory");
            inventory.AddToInventory("CameraPiece1"); 
            Debug.Log(inventory.inventory[0]);
            Debug.Log(inventory.inventory[1]);
            hasWon = true;
            currentNote = 0;
            Debug.Log("win");
        }
    }
}
