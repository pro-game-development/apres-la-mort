using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_LA2_Note : MonoBehaviour
{
    public AudioSource LA2_Note;

    private void OnMouseDown() {
        {
            LA2_Note.Play();
            Song song = new Song();
            song.checkNote("LA2");
        }
    }
}
