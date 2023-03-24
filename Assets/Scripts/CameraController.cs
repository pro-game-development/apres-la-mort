using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera camara;
    private bool switched = false;

    void OnTriggerEnter(Collider other) {
        if (!switched && other.CompareTag("Player")) {
            camara.gameObject.SetActive(true);
            switched = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (switched && other.CompareTag("Player")) {
            camara.gameObject.SetActive(false);
            switched = false;
        }
    }
}
