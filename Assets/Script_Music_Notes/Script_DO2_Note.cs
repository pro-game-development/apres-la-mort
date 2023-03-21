using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Script_DO2_Note : MonoBehaviour
{
    public AudioSource DO2_Note;

    private void Update() {
        if (Gamepad.current != null && Gamepad.current.leftShoulder.wasPressedThisFrame)
        {
            DO2_Note.Play();
            Song song = new Song();
            song.checkNote("DO2");
        }
    }
}