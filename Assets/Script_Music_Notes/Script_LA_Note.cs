using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Script_LA_Note : MonoBehaviour
{
    public AudioSource LA_Note;

    private void Update() {
        
        if (Gamepad.current != null && Gamepad.current.dpad.left.wasPressedThisFrame)
        {
            Debug.Log("leftdpad");
            Song song = new Song();
            LA_Note.Play();
            song.checkNote("LA");
        }
        
    }
}

