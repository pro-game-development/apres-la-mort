using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_SI_Note : MonoBehaviour
{
    public AudioSource SI_Note;

    private void OnMouseDown() {
        {
            SI_Note.Play();
            Song song = new Song();
            song.checkNote("SI");
        }
    }
}
