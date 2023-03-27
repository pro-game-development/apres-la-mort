using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_LAb_Note : MonoBehaviour
{
    public AudioSource LAb_Note;

    private void OnMouseDown() {
        {
            LAb_Note.Play();
            Song song = new Song();
            song.checkNote("LAb");
        }
    }
}
