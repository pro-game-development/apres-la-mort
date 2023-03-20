using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_MI_Note : MonoBehaviour
{
    public AudioSource MI_Note;

    private void OnMouseDown() {
        {
            MI_Note.Play();
        }
    }
}
