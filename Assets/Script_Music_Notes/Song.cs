using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song : MonoBehaviour
{
    private string[] notes = {"MI","FA","MI","RE","RE","MI","RE","DO","DO","RE","DO","SI","DO","SI","LA"};
    private static int currentNote = 0;
    private static bool hasWon = false;

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
        
        if(currentNote > 17){
            hasWon = true;
            currentNote = 0;
            Debug.Log("win");
        }
    }
}
