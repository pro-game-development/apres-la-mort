using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class ShowNote : MonoBehaviour
{
    public float readRange = 1f;
    public TextMeshProUGUI readNoteMessage;
    public TextMeshProUGUI closeNoteMessage;
    public TextMeshProUGUI noteMessage;
    public Image noteImage;
    bool showNote = false;
    // Start is called before the first frame update
    void Start()
    {
        readNoteMessage.gameObject.SetActive(false);
        closeNoteMessage.gameObject.SetActive(false);
        noteMessage.gameObject.SetActive(false);
        noteImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.instance.player == null)
        {
            return;
        }

        if (Vector3.Distance(transform.position, PlayerManager.instance.player.transform.position) <= readRange && Gamepad.current != null && Gamepad.current.buttonWest.wasPressedThisFrame)
        {
            if(!showNote)
            {
                noteImage.gameObject.SetActive(true);
                noteMessage.gameObject.SetActive(true);
                showNote = true;
            }
            else
            {
                noteImage.gameObject.SetActive(false);
                noteMessage.gameObject.SetActive(false);
                showNote = false;
            }
        }

        else if (Vector3.Distance(transform.position, PlayerManager.instance.player.transform.position) <= readRange)
        {
            if(!showNote)
            {
                readNoteMessage.gameObject.SetActive(true);
                closeNoteMessage.gameObject.SetActive(false);
            }
            else
            {
                readNoteMessage.gameObject.SetActive(false);
                closeNoteMessage.gameObject.SetActive(true);
            }
        }
        else
        {
            noteImage.gameObject.SetActive(false);
            noteMessage.gameObject.SetActive(false);
            readNoteMessage.gameObject.SetActive(false);
            closeNoteMessage.gameObject.SetActive(false);
            showNote = false;
        }

        
    }
}
