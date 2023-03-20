using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_LA_Note : MonoBehaviour
{
    public AudioSource LA_Note;

    private void OnMouseDown() {
        {
            LA_Note.Play();
        }
    }
}
