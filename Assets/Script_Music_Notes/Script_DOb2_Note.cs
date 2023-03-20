using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_DOb2_Note : MonoBehaviour
{
    public AudioSource DOb2_Note;

    private void OnMouseDown() {
        {
            DOb2_Note.Play();
        }
    }
}
