using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_SOLb_Note : MonoBehaviour
{
    public AudioSource SOLb_Note;

    private void OnMouseDown() {
        {
            SOLb_Note.Play();
        }
    }
}
