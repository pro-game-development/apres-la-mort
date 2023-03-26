using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class EnterClockPuzzle : MonoBehaviour
{
    public float interactionRange = 3f;
    //Clock text
    public TextMeshProUGUI checkClockText;
    public TextMeshProUGUI needClockHandsText;
    public Camera clockCamera;

    //Instructions
    public TextMeshProUGUI clockInstructions;
    
    public MoveClockHands clockHandsScript;

    private void Start(){
        //Clock text
        checkClockText.gameObject.SetActive(false);
        needClockHandsText.gameObject.SetActive(false);
        clockInstructions.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, PlayerManager.instance.player.transform.position) <= interactionRange && Gamepad.current != null && Gamepad.current.buttonWest.wasPressedThisFrame)
        {
            Inventory inventory = Resources.Load<Inventory>("Inventory");
            // IsPuzzle isPuzzle = new IsPuzzle();

            checkClockText.gameObject.SetActive(false);

            if(inventory.inventory.Contains("ClockHands")){
                //Cameras
                Camera activeCamera = Camera.current;
                activeCamera.gameObject.SetActive(false);
                clockCamera.gameObject.SetActive(true);

                //canvas
                clockInstructions.gameObject.SetActive(true);

                clockHandsScript.enabled = true;
            }
            else{
                needClockHandsText.gameObject.SetActive(true);
            }
        }

        else if (Vector3.Distance(transform.position, PlayerManager.instance.player.transform.position) <= interactionRange)
        {
            checkClockText.gameObject.SetActive(true);
        }

        else
        {
            checkClockText.gameObject.SetActive(false);
            clockInstructions.gameObject.SetActive(false);

            clockHandsScript.enabled = false;
        }
    }
}
