using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera2 : MonoBehaviour
{
    //Distance between the camera and player
    public Vector3 offset;
    //target = player, the camera will be aim to the player
    private Transform target;
    //this variable will tell unity how to pass from a position to another
    [Range (0, 1)]public float lerpValue;
    public float sensitivity;

    // Start is called before the first frame update
    void Start()
    {
        //the camera will be searching for something called "Player" in this case is the name that I
        //have to the model in unity
        target = GameObject.Find("Player").transform;
    }

    // LateUpdate is called at the end of each frame
    void LateUpdate()
    {
        //vector3.Lerp will move the position of an object from its vector to other vector
        //The movement will be so smooth
        //The camera will move from         its position    until target position plus the offset to not be over the player
        transform.position = Vector3.Lerp(transform.position, target.position + offset, lerpValue);
        //To move the camera in X with mouse
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensitivity, Vector3.up) * offset;
        
        transform.LookAt(target);
    }
}
