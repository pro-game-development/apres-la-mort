using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_DO_Note : MonoBehaviour
{
    public AudioSource DO_Note;

    private void OnMouseDown() {
        {
            DO_Note.Play();
        }
    }
}
