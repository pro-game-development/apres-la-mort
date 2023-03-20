using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_FA_Note : MonoBehaviour
{
    public AudioSource FA_Note;

    private void OnMouseDown() {
        {
            FA_Note.Play();
        }
    }
}
