using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_FAb_Note : MonoBehaviour
{
    public AudioSource FAb_Note;

    private void OnMouseDown() {
        {
            FAb_Note.Play();
        }
    }
}
