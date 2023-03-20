using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_RE2_Note : MonoBehaviour
{
    public AudioSource RE2_Note;

    private void OnMouseDown() {
        {
            RE2_Note.Play();
        }
    }
}
