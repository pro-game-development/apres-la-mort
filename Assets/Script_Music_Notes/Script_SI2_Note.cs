using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_SI2_Note : MonoBehaviour
{
    public AudioSource SI2_Note;

    private void OnMouseDown() {
        {
            SI2_Note.Play();
        }
    }
}
