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

    private PlayerHP hp;

    void Start()
    {
        hp = GameObject.FindWithTag("Player").GetComponent<PlayerHP>();
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
            hp.hp += -10;
        }
        
        if(currentNote > 14){
            
            Inventory inventory = Resources.Load<Inventory>("Inventory");
            inventory.AddToInventory("CameraPiece1"); 
            hasWon = true;
            currentNote = 0;
            Debug.Log("win");
        }
    }
}
