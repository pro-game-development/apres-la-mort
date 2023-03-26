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
    public Camera clockRoomCamera;

    //Instructions
    public TextMeshProUGUI clockInstructions;
    
    public MoveClockHands clockHandsScript;
    public Movement playerMovement;

    public bool isInClock = false;
    private int hasWonAux = 0;

    private void Start(){
        //Clock text
        checkClockText.gameObject.SetActive(false);
        needClockHandsText.gameObject.SetActive(false);
        clockInstructions.gameObject.SetActive(false);
        clockHandsScript.enabled = false;
    }

    private void Update()
    {
        if(MoveClockHands.hasWon == true){
            if(hasWonAux == 0){
                clockCamera.gameObject.SetActive(false);
                clockRoomCamera.gameObject.SetActive(true);
                hasWonAux = 1;
                DeactivateClock();
            }
            return;
        }

        if(isInClock && Gamepad.current != null && Gamepad.current.selectButton.wasPressedThisFrame){
            clockCamera.gameObject.SetActive(false);
            clockRoomCamera.gameObject.SetActive(true);
            isInClock = false;

            DeactivateClock();
        }

        if (Vector3.Distance(transform.position, PlayerManager.instance.player.transform.position) <= interactionRange && Gamepad.current != null && Gamepad.current.buttonWest.wasPressedThisFrame && !isInClock)
        {
            Inventory inventory = Resources.Load<Inventory>("Inventory");
            // IsPuzzle isPuzzle = new IsPuzzle();

            checkClockText.gameObject.SetActive(false);

            // if(inventory.inventory.Contains("ClockHands")){
                playerMovement.enabled = false;
                //Cameras
                Camera activeCamera = Camera.current;
                activeCamera.gameObject.SetActive(false);
                clockCamera.gameObject.SetActive(true);

                //canvas
                clockInstructions.gameObject.SetActive(true);
                checkClockText.gameObject.SetActive(false);

                clockHandsScript.enabled = true;
                isInClock = true;
            // }
            // else{
            //     needClockHandsText.gameObject.SetActive(true);
            // }
        }

        else if (Vector3.Distance(transform.position, PlayerManager.instance.player.transform.position) <= interactionRange)
        {
            if(!isInClock){
                checkClockText.gameObject.SetActive(true);
            }
        }

        else
        {
            DeactivateClock();
        }
    }

    void DeactivateClock(){
        checkClockText.gameObject.SetActive(false);
        clockInstructions.gameObject.SetActive(false);
        needClockHandsText.gameObject.SetActive(false);

        clockHandsScript.enabled = false;
    }
}
