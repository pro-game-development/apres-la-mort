using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Script_SOL_Note : MonoBehaviour
{
    public AudioSource SOL_Note;

    private void Update() {
        if (Gamepad.current != null && Gamepad.current.buttonEast.wasPressedThisFrame)
        {
            SOL_Note.Play();
            Song song = new Song();
            song.checkNote("SOL");
        }
    }
}
