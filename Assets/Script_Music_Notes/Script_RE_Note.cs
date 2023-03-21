using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Script_RE_Note : MonoBehaviour
{
    public AudioSource RE_Note;

    private void Update() {
        if (Gamepad.current != null && Gamepad.current.dpad.down.wasPressedThisFrame)
        {
            RE_Note.Play();
            Song song = new Song();
            song.checkNote("RE");
        }
    }
}
