using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SoundRandomizer : MonoBehaviour
{
    public AudioClip[] sounds;
    private AudioSource source;
    [Range(0.1f,0.5f)]
    public float volumeChangeMultiplier = 0.2f;
    [Range(0.1f,0.5f)]
    public float pitchChangeMultiplier = 0.2f;

    void Start(){
        
        source = GetComponent<AudioSource>();

    }

    void Update() {
        if(Gamepad.current.buttonWest.wasPressedThisFrame)
        {    
            source.clip = sounds[Random.Range(0, sounds.Length)];
            source.volume = Random.Range(1 - volumeChangeMultiplier, 1);
            source.pitch = Random.Range(1 - pitchChangeMultiplier, 1 + pitchChangeMultiplier);
            source.PlayOneShot(source.clip);
        }
    }
}
