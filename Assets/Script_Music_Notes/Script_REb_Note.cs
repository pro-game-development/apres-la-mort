using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_REb_Note : MonoBehaviour
{
    public AudioSource REb_Note;

    private void OnMouseDown() {
        {
            REb_Note.Play();
        }
    }
}
