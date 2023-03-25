using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinuteHand : MonoBehaviour
{
    public Transform pivot; // the pivot point to rotate around
    public float rotateSpeed = 300f; // the speed of rotation

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(pivot.position, Vector3.right, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(pivot.position, Vector3.left, rotateSpeed * Time.deltaTime);
        }
    }
}
