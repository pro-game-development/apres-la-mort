using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Script_RE2_Note : MonoBehaviour
{
    public AudioSource RE2_Note;

    private void Update() {
        if (Gamepad.current != null && Gamepad.current.rightTrigger.wasPressedThisFrame)
        {
            RE2_Note.Play();
            Song song = new Song();
            song.checkNote("RE2");
        }
    }
}
