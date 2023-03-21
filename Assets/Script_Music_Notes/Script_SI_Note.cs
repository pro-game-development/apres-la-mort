using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Script_SI_Note : MonoBehaviour
{
    public AudioSource SI_Note;

    private void Update() {
        if (Gamepad.current != null && Gamepad.current.dpad.up.wasPressedThisFrame)
        {
            SI_Note.Play();
            Song song = new Song();
            song.checkNote("SI");
        }
    }
}
