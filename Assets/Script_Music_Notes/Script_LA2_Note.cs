using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Script_LA2_Note : MonoBehaviour
{
    public AudioSource LA2_Note;

    private void Update() {
        if (Gamepad.current != null && Gamepad.current.buttonSouth.wasPressedThisFrame)
        {
            LA2_Note.Play();
            Song song = new Song();
            song.checkNote("LA2");
        }
    }
}
