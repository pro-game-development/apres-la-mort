using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_LAb2_Note : MonoBehaviour
{
    public AudioSource LAb2_Note;

    private void OnMouseDown() {
        {
            LAb2_Note.Play();
            Song song = new Song();
            song.checkNote("LAb2");
        }
    }
}
