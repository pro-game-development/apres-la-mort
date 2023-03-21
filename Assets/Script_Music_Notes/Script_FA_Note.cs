using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Script_FA_Note : MonoBehaviour
{
    public AudioSource FA_Note;

    private void Update() {
        if (Gamepad.current != null && Gamepad.current.buttonNorth.wasPressedThisFrame)
        {
            FA_Note.Play();
            Song song = new Song();
            song.checkNote("FA");
        }
    }
}
