using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement: MonoBehaviour
{
    public float rotateSpeed = 90;
    public float speed = 5.0f;
    public float shiftSpeed = 6.0f;
    public Animator ani;
    float nextFire;
    public AudioSource Walk;

    void Start()
    {
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        var transAmount = speed * Time.deltaTime;
        var transAmount2 = shiftSpeed * Time.deltaTime;
        var rotateAmount = rotateSpeed * Time.deltaTime;

        //FrontWalk
        if (Input.GetAxis("Vertical") > 0)
        {
            ani.SetBool("walk", true);
            transform.Translate(0, 0, transAmount);
            Walk.Play();
        }else{
            ani.SetBool("walk", false);
        }

        //BackWalk
        if (Input.GetAxis("Vertical") < 0)
        {
            ani.SetBool("backwalk", true);
            transform.Translate(0, 0, -transAmount);
            Walk.Play();
        }else{
            ani.SetBool("backwalk", false);
        }

        
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Rotate(0, -rotateAmount, 0);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Rotate(0, rotateAmount, 0);
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("up"))
        {
            ani.SetBool("run", true);
            transform.Translate(0, 0, transAmount2);
        }else{
            ani.SetBool("run", false);
        }
        if (Gamepad.current != null && Gamepad.current.buttonWest.wasPressedThisFrame){
            ani.SetBool("pick", true);
        }else{
            ani.SetBool("pick", false);
        }
    }
}