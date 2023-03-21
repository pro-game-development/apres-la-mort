using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_DO_Note : MonoBehaviour
{
    public AudioSource DO_Note;

    private void OnMouseDown() {
        {
            Song song = new Song();
            DO_Note.Play();
            song.checkNote("DO");
        }
    }
}
