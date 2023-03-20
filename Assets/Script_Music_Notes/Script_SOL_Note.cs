using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_SOL_Note : MonoBehaviour
{
    public AudioSource SOL_Note;

    private void OnMouseDown() {
        {
            SOL_Note.Play();
        }
    }
}
