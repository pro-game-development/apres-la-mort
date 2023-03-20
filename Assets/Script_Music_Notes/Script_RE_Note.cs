using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_RE_Note : MonoBehaviour
{
    public AudioSource RE_Note;

    private void OnMouseDown() {
        {
            RE_Note.Play();
        }
    }
}
