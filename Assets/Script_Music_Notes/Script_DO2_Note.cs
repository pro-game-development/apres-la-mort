using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_DO2_Note : MonoBehaviour
{
    public AudioSource DO2_Note;

    private void OnMouseDown() {
        {
            DO2_Note.Play();
            Song song = new Song();
            song.checkNote("DO2");
        }
    }
}
