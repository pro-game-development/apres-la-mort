using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Script_MI_Note : MonoBehaviour
{
    public AudioSource MI_Note;

    private void Update() {
        if (Gamepad.current != null && Gamepad.current.buttonWest.wasPressedThisFrame)
        {
            Song song = new Song();
            MI_Note.Play();
            song.checkNote("MI");
        }
    }
}
