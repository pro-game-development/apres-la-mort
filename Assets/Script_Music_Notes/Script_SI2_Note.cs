using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Script_SI2_Note : MonoBehaviour
{
    public AudioSource SI2_Note;

    private void Update() {
        if (Gamepad.current != null && Gamepad.current.leftTrigger.wasPressedThisFrame)
        {
            SI2_Note.Play();
            Song song = new Song();
            song.checkNote("SI2");
        }
    }
}
