using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_DOb_Note : MonoBehaviour
{
    public AudioSource DOb_Note;

    private void OnMouseDown() {
        {
            DOb_Note.Play();
        }
    }
}
