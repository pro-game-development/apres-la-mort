using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Script_DO_Note : MonoBehaviour
{
    public AudioSource DO_Note;

    private void Update() {
        if (Gamepad.current != null && Gamepad.current.dpad.right.wasPressedThisFrame)
        {
            Song song = new Song();
            DO_Note.Play();
            song.checkNote("DO");
        }
    }
}
