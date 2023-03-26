using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveClockHands : MonoBehaviour
{
    public Transform hours; // the pivot point to rotate around
    public Transform minutes; // the pivot point to rotate around
    public float rotateSpeedHours = 25f; // the speed of rotation
    public float rotateSpeedMinutes = 300f; // the speed of rotation
    public static bool hasWon = false;

    // Update is called once per frame
    void Update()
    {
        float hourPosition = hours.localEulerAngles.y;
        float minutePosition = minutes.localEulerAngles.y;

        if (Gamepad.current.dpad.right.isPressed)
        {
            hours.RotateAround(hours.position, Vector3.right, rotateSpeedHours * Time.deltaTime);
            minutes.RotateAround(minutes.position, Vector3.right, rotateSpeedMinutes * Time.deltaTime);
            Debug.Log("hour: " + hours.localEulerAngles.y);
            Debug.Log("minute: " + minutes.localEulerAngles.y);
        }
        if (Gamepad.current.dpad.left.isPressed)
        {
            hours.RotateAround(hours.position, Vector3.left, rotateSpeedHours * Time.deltaTime);
            minutes.RotateAround(minutes.position, Vector3.left, rotateSpeedMinutes * Time.deltaTime);
            Debug.Log("hour: " + hours.localEulerAngles.y);
            Debug.Log("minute: " + minutes.localEulerAngles.y);
        }
        if(Gamepad.current != null && Gamepad.current.buttonWest.wasPressedThisFrame)
        {
            if(hourPosition >= 125 && hourPosition <= 128 && minutePosition >= 80 && minutePosition <= 97.5)
            {
                Inventory inventory = Resources.Load<Inventory>("Inventory");
                inventory.AddToInventory("CameraPiece2"); 
                Debug.Log(inventory.inventory[0]);
                hasWon = true;
                Debug.Log("win");
                Debug.Log("Correct time");
            }
            else Debug.Log("Incorrect time");
        }
    }
}
