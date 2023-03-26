using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveClockHands : MonoBehaviour
{
    public Transform hours; // the pivot point to rotate around
    public Transform minutes; // the pivot point to rotate around
    public float rotateSpeedHours = 25f; // the speed of rotation
    public float rotateSpeedMinutes = 300f; // the speed of rotation

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            hours.RotateAround(hours.position, Vector3.right, rotateSpeedHours * Time.deltaTime);
            minutes.RotateAround(minutes.position, Vector3.right, rotateSpeedMinutes * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            hours.RotateAround(hours.position, Vector3.left, rotateSpeedHours * Time.deltaTime);
            minutes.RotateAround(minutes.position, Vector3.left, rotateSpeedMinutes * Time.deltaTime);
        }
    }
}
