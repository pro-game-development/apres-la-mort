using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement: MonoBehaviour
{
    public float rotateSpeed = 90;
    public float speed = 5.0f;
    public float shiftSpeed = 6.0f;
    public float fireInterval = 0.5f;
    public float bulletSpeed = 20;
    public Transform spawnPoint;
    public GameObject bulletObject;
    public Animator ani;
    float nextFire;

    /*public float jump = 5.0f;*/

    void Start()
    {
        ani = GetComponent<Animator>();
        nextFire = Time.time + fireInterval;
    }

    void Update()
    {
        var transAmount = speed * Time.deltaTime;
        var transAmount2 = shiftSpeed * Time.deltaTime;
        var rotateAmount = rotateSpeed * Time.deltaTime;

        /*var jumpp = jump * Time.deltaTime;*/

        /*To switch bewteen the arrows keys and wasd just change "Input.GetKey("up")" to Input.GetKey(KeyCode.w)*/

        if (Input.GetAxis("Vertical") > 0)
        {
            ani.SetBool("walk", true);
            transform.Translate(0, 0, transAmount);
        }else{
            ani.SetBool("walk", false);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            ani.SetBool("backwalk", true);
            transform.Translate(0, 0, -transAmount);
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
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireInterval;
            fire();
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("up"))
        {
            ani.SetBool("run", true);
            transform.Translate(0, 0, transAmount2);
        }else{
            ani.SetBool("run", false);
        }
        /*En caso de que se quiera utilizar salto
        if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, jumpp, 0);
        }*/

        if (Input.GetKeyDown(KeyCode.E)){
            ani.SetBool("pick", true);
        }else{
            ani.SetBool("pick", false);
        }
    }

    void fire()
    {
        var bullet = Instantiate(bulletObject, spawnPoint.position, spawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
    }
}